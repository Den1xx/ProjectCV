using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class CertificateDal
    {
        private readonly DataContext _context;
        public CertificateDal()
        {
            _context = new DataContext();
        }
        public List<Certificate> GetAllCertificates()
        {
            return _context.Certificates.ToList();
        }
    }
}
