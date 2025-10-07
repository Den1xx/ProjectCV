﻿using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class CertificateService
    {
        private readonly CertificateDal _certificateDal;
        public CertificateService()
        {
            _certificateDal = new CertificateDal();
        }
        public List<Certificate> GetAllCertificates()
        {
            return _certificateDal.GetAllCertificates().ToList();
        }
        public void Update(Certificate certUpdate)
        {
            _certificateDal.Update(certUpdate);
        }


    }
}
