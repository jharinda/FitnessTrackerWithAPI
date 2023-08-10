using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.Classes
{
    public class User
    {
        public User()
        {
            Records = new List<Record>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public float HeightInCm { get; set; }
        public List<Record> Records { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public void addRecord(Record record)
        {
            var found = Records.Find(x => x.Date == record.Date);

            if (found == null) 
            {
                Records.Add(record);
            }
            else
            {
                MessageBox.Show("A record is already inserted for this date and time");
            }

        }

        public void sortRecords()
        {
            Records.Sort((x, y) => y.Date.CompareTo(x.Date));
            Records.Reverse();
        }

        public string getWeightStatus()
        {
            string status = "";
            int calorieIntake = 0;
            int calorieBurned = 0;

            sortRecords();

            if (Records.Count <= 7) {
                status = "No enough data";
            }
            else
            {
                int lastRecordIndex = Records.Count - 1;
                for (int i = 0; i <= 7; i++) 
                {
                    calorieIntake += Records[lastRecordIndex].getMealCalories();
                    calorieBurned += Records[lastRecordIndex].getWorkoutCalories();
                    lastRecordIndex -= 1;
                }

                if (calorieIntake > calorieBurned)
                {
                    status = "Gaining Weight";
                }
                else
                {
                    status = "Losing Weight";
                }
            }
            
            return status;
        }

        public void updateRecord(Record record)
        {
            Record selectedRecord = Records.Find(r => r.Date == record.Date);
            Records.Remove(selectedRecord);
            Records.Add(record);

            sortRecords();
        }
    }
}
