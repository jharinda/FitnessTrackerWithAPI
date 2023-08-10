using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerNet4.Services.DTO
{
    class RecordDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public float Weight { get; set; }
        public List<RecordWiseMealDTO> RecordWiseMeals { get; set; }
        public List<RecordWiseWorkoutDTO> RecordWiseWorkouts { get; set; }
    }
}
