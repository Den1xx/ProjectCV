using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.DTOs.SkillDTO
{
    public class SkillCreateDTO
    {
        public string Name { get; set; }
        [Range(0, 100)]
        public int Rating { get; set; }
    }
}
