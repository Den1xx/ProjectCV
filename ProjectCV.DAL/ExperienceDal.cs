﻿using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class ExperienceDal
    {
        private readonly DataContext _context;
        public ExperienceDal()
        {
            _context = new DataContext();
        }
        public List<Experiance> GetExperiences()
        {
            return _context.Experiances.ToList();
        }
    }
}
