using FitnessTracker.Classes;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FitnessTracker.Forms
{
    public partial class Profile : Form
    {
        private readonly Double BMIOverWeight = 24.9;
        private readonly Double BMIUnderWeight = 18.5;
        private RepositoryService repositoryService = new RepositoryService();
        private User user = new User();
        public Profile()
        {
            FitnessTrackerData data = new FitnessTrackerData();
            InitializeComponent();
            generateData();
        }

        private void generateData() 
        {
            loadUserData();
           
        }

        public void loadListView()
        {
            DataTable dto = new DataTable();
            dto.Columns.Add("Date",typeof(DateTime));
            dto.Columns.Add("Weight",typeof(float));
            dto.Columns.Add("Meals",typeof(string));
            dto.Columns.Add("Workouts",typeof(string));
            user.sortRecords();
            List<Record> records = user.Records;

            string meals = "";
            string workouts = "";

            foreach(Record record in records)
            {

                foreach(var obj in record.Meals.ToArray())
                {
                    meals += obj.Key.Name + " x " + obj.Value.ToString() + ", ";
                }

                foreach (var obj in record.Workouts.ToArray())
                {
                    workouts += obj.Key.Name + " x " + obj.Value.ToString() + ", ";
                }

                dto.Rows.Add(record.Date,record.Weight, meals, workouts);
            }

            dataGridView_records.DataSource = dto;
        }

        private void generateWorkoutVsMealChart()
        {
            chart_mealVsWorkout.Series["Workout"].Points.Clear();
            chart_mealVsWorkout.Series["Meal"].Points.Clear();
            foreach (Record record in user.Records)
            {
                int workoutCalories = record.getWorkoutCalories();
                int mealCalories = record.getMealCalories();
                chart_mealVsWorkout.Series["Workout"].Points.AddXY(record.Date, workoutCalories);
                chart_mealVsWorkout.Series["Meal"].Points.AddXY(record.Date, mealCalories);
            }
        }

        private void generateBMIStatus()
        {
            user.sortRecords();
            float BMIValue ;

            if (user.Records.Count > 0) 
            { 
                BMIValue = user.Records[user.Records.Count - 1].calcBMI(user.HeightInCm);
            }
            else 
            {
                lbl_bmi_status.Text = "No enough data";
                return;
            }

            if (BMIValue >= BMIOverWeight) {
                lbl_bmi_status.Text = "Overweight";
            }
            else if (BMIValue <= BMIUnderWeight)
            {
                lbl_bmi_status.Text = "Underweight";
            }
            else 
            {
                lbl_bmi_status.Text = "Healthy";
            }

        }

        private void generateBMI()
        {
            chart_bmi.Series["CurrentBMI"].Points.Clear();
            chart_bmi.Series["Overweight"].Points.Clear();
            chart_bmi.Series["Underweight"].Points.Clear();

            foreach (Record record in user.Records)
            {
                chart_bmi.Series["CurrentBMI"].Points.AddXY(record.Date,record.calcBMI(user.HeightInCm));
                chart_bmi.Series["Overweight"].Points.AddXY(record.Date, BMIOverWeight);
                chart_bmi.Series["Underweight"].Points.AddXY(record.Date, BMIUnderWeight);
            }

            generateBMIStatus();
        }

        private void generateWorkoutChart()
        {
            chart_workout.Series["Workout"].Points.Clear();
            foreach (Record record in user.Records)
            {
                chart_workout.Series["Workout"].Points.AddXY(record.Date, record.getWorkoutCalories());
            }
        }

        private void generateWeightChart()
        {
            chart_weight.Series["Weight"].Points.Clear();
            foreach (Record record in user.Records)
            {
                chart_weight.Series["Weight"].Points.AddXY(record.Date, record.Weight);
            }
        }

        private void generateMealChart()
        {
            chart_meal.Series["Meal"].Points.Clear();
            foreach (Record record in user.Records)
            {
                chart_meal.Series["Meal"].Points.AddXY(record.Date, record.getMealCalories());
            }
        }

        private async void loadUserData()
        {
            user = await repositoryService.GetCurrentUser().ConfigureAwait(true);
            /*if(FitnessTrackerData.user != null) 
             {
                 user = FitnessTrackerData.user;
             }*/

            loadListView();
            assignToLables();

            generateWorkoutVsMealChart();
            generateMealChart();
            generateWorkoutChart();
            generateWeightChart();
            generateBMI();
        }

        private void assignToLables()
        {
            lbl_name_output.Text = user.Name;
            lbl_age_output.Text = user.Age.ToString();
            lbl_gender_output.Text = user.Gender;
            lbl_height_output.Text = user.HeightInCm.ToString();

            user.sortRecords();

            if (user.Records.Count > 0)
            {
                lbl_weight_output.Text = user.Records[user.Records.Count - 1].Weight.ToString();
            }
            else
            {
                lbl_weight_output.Text = "No data";
            }

            lbl_weightStatus_output.Text = user.getWeightStatus();

        }

        private async void dataGridView_records_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (user.Records.Count <= e.RowIndex) return;

                Record selectedRecord = user.Records[e.RowIndex];

                // edit button clicked
                if(e.ColumnIndex == 0)
                {
                    FitnessTrackerForms.DailyDetailsForm = new DailyDetails(true, selectedRecord);
                    FitnessTrackerForms.DailyDetailsForm.Show();
                }
                // delete button clicked
                else if (e.ColumnIndex == 1)
                {
                    FitnessTrackerData.user.Records.Remove(selectedRecord);
                    await repositoryService.DeleteRecord(selectedRecord);
                    loadListView();
                    generateData();
                }
                
            }
        }
    }
}
