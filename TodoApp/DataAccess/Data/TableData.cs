using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class TableData : ITableData
    {
        private readonly ISqlDataAccess _db;
        public TableData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<TableModel>> GetTables() =>
            _db.LoadData<TableModel, dynamic>("dbo.sp_Tables_Get",  new {});
    }
}
