using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class SeedlessnessManager : BaseSqlManager, IDbManagable<SeedlessnessType>
    {
        #region CONSTRUCTORS
        public SeedlessnessManager(string connectionString):
            base(connectionString)
        {
        }
        #endregion

        #region I_DB_MANAGABLE
        public void DeleteData(SeedlessnessType data)
        {
            throw new NotImplementedException();
        }

        public void EditData(SeedlessnessType data)
        {
            throw new NotImplementedException();
        }

        public List<SeedlessnessType> GetData()
        {
            const string queryString = "select * from SeedlessnessType";
            List<SeedlessnessType> result = new List<SeedlessnessType>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new SeedlessnessType((int)reader[0], reader[1] as string));
            return result;
        }

        public void LoadData(SeedlessnessType data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
