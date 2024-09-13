using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApi.Entities.appEntities;

namespace testApi.Abstract
{
    public interface ICompanyRepository2
    {
           List<Company2> GetAll();

           Company2 GetCompanyById(int id);
        Company2 CreateCompany(Company2 company);
        Company2 UpdateCompany(Company2 company);
        void DeleteCompany(int id);
    }
}
