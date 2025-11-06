using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.DTOs.ExperienceDTO
{
    public class ExperienceCreateDTO
    {
        [StringLength(30)]
        public string CompanyName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
