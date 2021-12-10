using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface ITableData
    {
        Task<IEnumerable<TableModel>> GetTables();
    }
}