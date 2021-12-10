using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class CompanyData : ICompanyData
    {
        private readonly ISqlDataAccess _db;
        public CompanyData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<CompanyModel>> GetCompanys() =>
            _db.LoadData<CompanyModel, dynamic>("sp_Company_GetAll", new { });

        public async Task<CompanyModel> GetCompany(int id)
        {
            var results = await _db.LoadData<CompanyModel, dynamic>("sp_Company_Get", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertCompany(CompanyModel model) =>
            _db.SaveData("sp_Company_Insert", new { model.FirstName, model.LastName, model.Country });

        public Task UpdateCompany(CompanyModel model) =>
            _db.SaveData("sp_Company_Update", model);

        public Task DeleteCompany(int id) =>
            _db.SaveData("sp_Company_Delete", new { Id = id });
    }
}
