using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class SortManager : BaseSqlManager, IDbManagable<GrapeSort>
    {
        #region CONSTRUCTORS
        public SortManager(string connectionString) :
            base(connectionString)
        {
        }
        #endregion

        #region I_DB_MANAGABLE
        public void DeleteData(GrapeSort data)
        {

        }
        public void EditData(GrapeSort data)
        {
        }
        public List<GrapeSort> GetData()
        {
            const string queryString = "select * from GrapeSort";
            List<GrapeSort> result = new List<GrapeSort>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new GrapeSort(reader));
            return result;
        }
        public void LoadData(GrapeSort data)
        {
        }
        #endregion
    }
}
