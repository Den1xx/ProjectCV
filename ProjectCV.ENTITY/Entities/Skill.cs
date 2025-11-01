using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.ENTITY.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Skill value must be between 0 and 100.")]
        public int Rating { get; set; }
    }
}
