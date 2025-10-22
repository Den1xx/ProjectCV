using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.DTOs.CertificatesUpdateDTO
{
    public class CertificatesUpdateDTO
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public string Institution { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
