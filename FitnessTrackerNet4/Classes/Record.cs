using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FitnessTracker.Classes
{
    public class Record
    {
        public Record()
        {
            Meals = new Dictionary<Meal, int>();
            Workouts = new Dictionary<Workout, int>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Weight { get; set; }
        public IDictionary<Meal, int> Meals { get; set; }
        public IDictionary<Workout, int> Workouts { get; set; }

        public bool addMeal(Meal meal,int quantity)
        {
            bool status = false;
            if (!Meals.ContainsKey(meal)) 
            { 
                Meals.Add(meal, quantity);
                status = true;
            }
            else
            {
                MessageBox.Show("Item Already exists");
            }

            return status;
        }

        public void removeMeal(Meal meal)
        {
            Meals.Remove(meal);
        }

        public float calcBMI(float heightInCm)
        {
            float heightInM = heightInCm / 100;
            float bmi = Weight / (heightInM * heightInM);
            return bmi;
        }

        public bool addWorkout(Workout workout, int quantity)
        {
            bool status = false;
            if (!Workouts.ContainsKey(workout))
            {
                Workouts.Add(workout, quantity);
                status = true;
            }
            else
            {
                MessageBox.Show("Item Already exists");
            }

            return status;
        }

        public void resetWorkouts()
        {
            Workouts = new Dictionary<Workout, int>();
        }

        public void resetMeals()
        {
            Meals = new Dictionary<Meal, int>();
        }

        public int getWorkoutCalories()
        {
            int calories = 0;

            foreach(var item in Workouts.ToArray())
            {
                calories += item.Value * item.Key.KalCount;
            }

            return calories;
        }

        public int getMealCalories()
        {
            int calories = 0;

            foreach (var item in Meals.ToArray())
            {
                calories += item.Value * item.Key.KalCount;
            }

            return calories;
        }

        public void removeWorkout(Workout workout)
        {
            Workouts.Remove(workout);
        }

        public int getWorkoutsCalories()
        {
            int calCount = 0;

            foreach (var workout in Workouts.ToArray())
            {
                calCount += workout.Value;
            }

            return calCount;
        }
    }


}
