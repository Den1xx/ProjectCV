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
        public void Create(Certificate certCreate)
        {
            _context.Certificates.Add(certCreate);
            _context.SaveChanges();
        }

        public int Update(Certificate certUpdate)
        {
            var certificate = _context.Certificates.FirstOrDefault(x => x.Id == certUpdate.Id);
            if (certificate != null)
            {
                certificate.Name = certUpdate.Name;
                certificate.Institution = certUpdate.Institution;
                certificate.StartDate = certUpdate.StartDate;
                certificate.EndDate = certUpdate.EndDate;

            }
            return _context.SaveChanges();
        }
        public Certificate Find(int id)
        {
            var certificate = _context.Certificates.Find(id);
            return certificate;
        }
        public void Delete(Certificate entity)
        {
            _context.Certificates.Remove(entity);
            _context.SaveChanges();
        }
    }
}
