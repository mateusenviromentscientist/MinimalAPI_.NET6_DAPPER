using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface ICompanyData
    {
        Task DeleteCompany(int id);
        Task<CompanyModel> GetCompany(int id);
        Task<IEnumerable<CompanyModel>> GetCompanys();
        Task InsertCompany(CompanyModel model);
        Task UpdateCompany(CompanyModel model);
    }
}