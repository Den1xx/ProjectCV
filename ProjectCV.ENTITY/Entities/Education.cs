using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.ENTITY.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Degree { get; set; }
        public string Text { get; set; }
    }
}
