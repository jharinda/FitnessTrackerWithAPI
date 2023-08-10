using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerNet4.Services.DTO
{
    class RecordWiseMealDTO
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int MealId { get; set; }
        public int MealQuantity { get; set; }
    }
}
