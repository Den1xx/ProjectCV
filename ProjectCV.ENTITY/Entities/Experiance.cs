using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.ENTITY.Entities
{
    public class Experience
    {
        public int Id { get; set; }

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
