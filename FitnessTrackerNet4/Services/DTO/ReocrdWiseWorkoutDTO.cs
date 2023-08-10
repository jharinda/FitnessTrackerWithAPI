using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerNet4.Services.DTO
{
    class RecordWiseWorkoutDTO
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int WorkoutId { get; set; }
        public int Reps { get; set; }
    }
}
