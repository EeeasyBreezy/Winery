using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class CountryManager : BaseSqlManager, IDbManagable<OriginCountry>
    {
        #region CONSTRUCTORS
        public CountryManager(string connectionString):
            base(connectionString)
        {
        }
        #endregion

        #region I_DB_MANAGABLE
        public void DeleteData(OriginCountry data)
        {
            throw new NotImplementedException();
        }

        public void EditData(OriginCountry data)
        {
            throw new NotImplementedException();
        }

        public List<OriginCountry> GetData()
        {
            const string queryString = "select * from OriginCountry";
            List<OriginCountry> result = new List<OriginCountry>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new OriginCountry((int)reader[0], reader[1] as string));
            return result;
        }

        public void LoadData(OriginCountry data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
