using FitnessTracker.Classes;
using System;
using System.Collections.Generic;


namespace FitnessTracker.Repository
{
    class FitnessTrackerData
    {
        public static readonly string tempFilePath = AppDomain.CurrentDomain.BaseDirectory + "temp.xml";
        public static User user = new User() { Name = "Janith", Age = 23, HeightInCm = 172, Gender = "Male" } ;
        public static List<Workout> workouts = new List<Workout>();
       /* {
            new Workout { Id = 1, KalCount = 10, Name = "Pushup"},
            new Workout { Id = 2, KalCount = 20, Name = "Pullup"},
            new Workout { Id = 3, KalCount = 30, Name = "Situp"}
        };*/

        public static List<Meal> meals = new List<Meal>();
        /*{
            new Meal { Id = 1, KalCount = 10, Name = "Sausage"},
            new Meal { Id = 2, KalCount = 20, Name = "Chips"},
            new Meal { Id = 3, KalCount = 30, Name = "Chicken"}
        };*/

        Dictionary<Workout, int> MockWorkout1 = new Dictionary<Workout, int>();
        Dictionary<Workout, int> MockWorkout2 = new Dictionary<Workout, int>();

        Dictionary<Meal, int> MockMeal1 = new Dictionary<Meal, int>();
        Dictionary<Meal, int> MockMeal2 = new Dictionary<Meal, int>();

        Record MockRecord1 = new Record();
        Record MockRecord2 = new Record();
        Record MockRecord3 = new Record();
        Record MockRecord4 = new Record();
        Record MockRecord5 = new Record();
        Record MockRecord6 = new Record();
        Record MockRecord7 = new Record();
        Record MockRecord8 = new Record();
        public FitnessTrackerData()
        {

            /*if (user.Records.Count <= 0) 
            {
                // MockData();
            }*/

        }

        private void MockData()
        {
            MockWorkout1.Add(workouts[0], 10);
            MockWorkout1.Add(workouts[1], 20);

            MockWorkout2.Add(workouts[1], 20);
            MockWorkout2.Add(workouts[2], 20);

            MockMeal1.Add(meals[1], 20);
            MockMeal1.Add(meals[2], 20);

            MockMeal2.Add(meals[0], 50);
            MockMeal2.Add(meals[2], 20);

            MockRecord1.Date = DateTime.Parse("2023-06-21");
            MockRecord1.Meals = MockMeal1;
            MockRecord1.Workouts = MockWorkout1;
            MockRecord1.Weight = 75;

            MockRecord2.Date = DateTime.Parse("2023-06-22");
            MockRecord2.Meals = MockMeal2;
            MockRecord2.Workouts = MockWorkout2;
            MockRecord2.Weight = 74;

            MockRecord3.Date = DateTime.Parse("2023-06-23");
            MockRecord3.Meals = MockMeal1;
            MockRecord3.Workouts = MockWorkout1;
            MockRecord3.Weight = 73;

            MockRecord4.Date = DateTime.Parse("2023-06-24");
            MockRecord4.Meals = MockMeal2;
            MockRecord4.Workouts = MockWorkout2;
            MockRecord4.Weight = 75;

            MockRecord5.Date = DateTime.Parse("2023-06-18");
            MockRecord5.Meals = MockMeal1;
            MockRecord5.Workouts = MockWorkout1;
            MockRecord5.Weight = 75;

            MockRecord6.Date = DateTime.Parse("2023-06-25");
            MockRecord6.Meals = MockMeal2;
            MockRecord6.Workouts = MockWorkout2;
            MockRecord6.Weight = 74;

            MockRecord7.Date = DateTime.Parse("2023-06-26");
            MockRecord7.Meals = MockMeal1;
            MockRecord7.Workouts = MockWorkout1;
            MockRecord7.Weight = 73;

            MockRecord8.Date = DateTime.Parse("2023-06-27");
            MockRecord8.Meals = MockMeal2;
            MockRecord8.Workouts = MockWorkout2;
            MockRecord8.Weight = 71;

            user.addRecord(MockRecord1);
            user.addRecord(MockRecord2);
            user.addRecord(MockRecord3);
            user.addRecord(MockRecord4);
            user.addRecord(MockRecord5);
            user.addRecord(MockRecord6);
            user.addRecord(MockRecord7);
            user.addRecord(MockRecord8);
        }



    }
}
