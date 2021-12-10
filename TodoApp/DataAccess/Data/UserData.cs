using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
            _db.LoadData<UserModel, dynamic>("dbo.sp_User_GetAll", new { });

        public async Task<UserModel?> GetUser(int id)
        {
            var results = await _db.LoadData<UserModel, dynamic>(
                "dbo.sp_User_get", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertUser(UserModel model) =>
            _db.SaveData("dbo.sp_User_Insert", new { model.FirstName, model.LastName });

        public Task UpdateUser(UserModel model) =>
            _db.SaveData("dbo.sp_User_Update", model);

        public Task DeleteUser(int id) =>
            _db.SaveData("dbo.sp_User_Delete", new { Id = id });

    }
}
