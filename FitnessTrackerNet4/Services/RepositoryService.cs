using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using FitnessTracker.Classes;
using Newtonsoft.Json;
using System.Windows.Forms;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Services.DTO;
using System.IO;
using System.Xml;

namespace FitnessTrackerNet4.Services
{
    class RepositoryService
    {
        // private readonly string USER_SERVICE_URL = "https://localhost:5001/api/Users";
        private readonly string USER_SERVICE_URL = "https://webapplication420230712231206.azurewebsites.net/api/Users";
        // private readonly string MEAL_SERVICE_URL = "https://localhost:44375/api/Meals";
        private readonly string MEAL_SERVICE_URL = "https://mealsapii.azurewebsites.net/api/Meals";
        // private readonly string WORKOUT_SERVICE_URL = "https://localhost:44313/api/Workouts";
        private readonly string WORKOUT_SERVICE_URL = "https://workoutsapi.azurewebsites.net/api/Workouts";
        public RepositoryService()
        {
           
            
        }

        public async void GetMeals()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(MEAL_SERVICE_URL);
            string str = await response.Content.ReadAsStringAsync();
            FitnessTrackerData.meals = JsonConvert.DeserializeObject <List<Meal>> (await response.Content.ReadAsStringAsync());
        }

        public async void GetWorkouts()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(WORKOUT_SERVICE_URL);
            FitnessTrackerData.workouts = JsonConvert.DeserializeObject<List<Workout>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<User> GetCurrentUser()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(USER_SERVICE_URL+"/"+ FitnessTrackerData.user.Email);
            string responseString = await response.Content.ReadAsStringAsync();
            UserDTO userDTO = JsonConvert.DeserializeObject<UserDTO>(await response.Content.ReadAsStringAsync());

            FitnessTrackerData.user = mapUserDTOToUser(userDTO);
            return FitnessTrackerData.user;
        }

        private User mapUserDTOToUser(UserDTO userDTO)
        {
            User user = new User();

            user.Id = userDTO.Id;
            user.Name = userDTO.Name;
            user.Email = userDTO.Email;
            user.Age = userDTO.Age;
            user.Password = userDTO.Password;
            user.HeightInCm = userDTO.HeightInCm;
            user.Gender = userDTO.Gender;

            foreach (RecordDTO recordDTO in userDTO.Records)
            {
                Record record = new Record();
                record.Date = recordDTO.Date;
                record.Weight = recordDTO.Weight;
                record.Id = recordDTO.Id;


                foreach(RecordWiseMealDTO recordWiseMealDTO in recordDTO.RecordWiseMeals)
                {
                    Meal meal = new Meal();
                    meal.Id = recordWiseMealDTO.MealId;
                    meal = FitnessTrackerData.meals.Where(m => m.Id == meal.Id).FirstOrDefault();
                    meal.WiseId = recordWiseMealDTO.Id;
                    record.Meals.Add(meal, recordWiseMealDTO.MealQuantity);
                }

                foreach (RecordWiseWorkoutDTO recordWiseWorkoutDTO in recordDTO.RecordWiseWorkouts)
                {
                    Workout workout = new Workout();
                    workout.Id = recordWiseWorkoutDTO.WorkoutId;
                    workout = FitnessTrackerData.workouts.Where(m => m.Id == workout.Id).FirstOrDefault();
                    workout.WiseId = recordWiseWorkoutDTO.Id;
                    record.Workouts.Add(workout, recordWiseWorkoutDTO.Reps);
                }

                user.addRecord(record);
            }

            return user;
        }

        public async Task RegisterAsync(User user)
        {
            HttpClient client = new HttpClient();
            
            var requestBody = user;

            HttpContent content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(USER_SERVICE_URL, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Done ");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            
        }

        public async Task<bool> ValidateAsync(string email, string password)
        {
            HttpClient client = new HttpClient();

            var requestBody = new User();
            requestBody.Email = email;
            requestBody.Password = password;

            HttpContent content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(USER_SERVICE_URL + "/validate", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();

                FitnessTrackerData.user = JsonConvert.DeserializeObject<User>(result);
                XmlDocument doc = JsonConvert.DeserializeXmlNode(result, "User");
                File.WriteAllText(FitnessTrackerData.tempFilePath, doc.OuterXml);
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }

        }

        public async Task<bool> AddRecord(Record record)
        {
            HttpClient client = new HttpClient();

            var requestBody = new RecordDTO();
            requestBody.Weight = record.Weight;
            requestBody.Id = record.Id;
            requestBody.UserId = FitnessTrackerData.user.Id;
            requestBody.Date = record.Date;

            requestBody.RecordWiseMeals = mapToRecordWiseMealDTO(record.Meals, record.Id);
            requestBody.RecordWiseWorkouts = mapToRecordWiseWorkoutDTO(record.Workouts, record.Id);


            HttpContent content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(USER_SERVICE_URL + "/Record", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                await GetCurrentUser();
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }

        }

        public async Task<bool> UpdateRecord(Record record)
        {
            HttpClient client = new HttpClient();

            var requestBody = new RecordDTO();
            requestBody.Weight = record.Weight;
            requestBody.Id = record.Id;
            requestBody.UserId = FitnessTrackerData.user.Id;
            requestBody.Date = record.Date;

            requestBody.RecordWiseMeals = mapToRecordWiseMealDTO(record.Meals, record.Id);
            requestBody.RecordWiseWorkouts = mapToRecordWiseWorkoutDTO(record.Workouts, record.Id);


            HttpContent content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync(USER_SERVICE_URL + "/Record", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                await GetCurrentUser();
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }

        }

        public async Task<bool> DeleteRecord(Record record)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync(USER_SERVICE_URL + "/Record/" + record.Id);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                await GetCurrentUser();
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }

        }

        private List<RecordWiseMealDTO> mapToRecordWiseMealDTO(IDictionary<Meal, int> meal,int recordId)
        {
            List<RecordWiseMealDTO> list = new List<RecordWiseMealDTO>();

            foreach (var x in meal)
            {
                RecordWiseMealDTO dto = new RecordWiseMealDTO();
                dto.MealId = x.Key.Id;
                dto.MealQuantity = x.Value;
                dto.RecordId = recordId;
                dto.Id = x.Key.WiseId;
                list.Add(dto);
            }
            return list;
        }

        private List<RecordWiseWorkoutDTO> mapToRecordWiseWorkoutDTO(IDictionary<Workout, int> workouts, int recordId)
        {
            List<RecordWiseWorkoutDTO> list = new List<RecordWiseWorkoutDTO>();

            foreach (var x in workouts)
            {
                RecordWiseWorkoutDTO dto = new RecordWiseWorkoutDTO();
                dto.WorkoutId = x.Key.Id;
                dto.Reps = x.Value;
                dto.RecordId = recordId;
                dto.Id = x.Key.WiseId;
                list.Add(dto);
            }
            return list;
        }


    }
}
