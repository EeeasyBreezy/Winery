using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class WineSortManager : BaseSqlManager, IDbManagable<WineSortCategory>
    {
        #region CONSTRUCTORS
        public WineSortManager(string connectionString):
            base(connectionString)
        {
        }
        #endregion

        #region I_DB_MANAGABLE
        public void DeleteData(WineSortCategory data)
        {
            throw new NotImplementedException();
        }

        public void EditData(WineSortCategory data)
        {
            throw new NotImplementedException();
        }

        public List<WineSortCategory> GetData()
        {
            const string queryString = "select * from WineSortCategory";
            List<WineSortCategory> result = new List<WineSortCategory>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new WineSortCategory((int)reader[0], reader[1] as string));
            return result;
        }

        public void LoadData(WineSortCategory data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
