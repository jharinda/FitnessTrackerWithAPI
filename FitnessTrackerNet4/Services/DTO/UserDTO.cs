using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerNet4.Services.DTO
{
    class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public float HeightInCm { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<RecordDTO> Records { get; set; }
    }
}
