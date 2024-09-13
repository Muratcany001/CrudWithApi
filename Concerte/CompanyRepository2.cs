using System.Collections.Generic;
using System.Linq;
using testApi.Entities;
using testApi.Entities.appEntities;
using testApi.Abstract;

namespace testApi.Concrete
{
    public class CompanyRepository2 : ICompanyRepository2
    {
        private readonly Context2 _context;

        public CompanyRepository2(Context2 context)
        {
            _context = context;
        }

        public Company2 CreateCompany(Company2 company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company;
        }

        public void DeleteCompany(int id)
        {
            var company = GetCompanyById(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }

        public List<Company2> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company2 GetCompanyById(int id)
        {
            return _context.Companies.Find(id);
        }

        public Company2 UpdateCompany(Company2 company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return company;
        }
    }
}
