using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class SweetnessManager : BaseSqlManager, IDbManagable<SweetnessDegree>
    {
        #region CONSTRUCTORS
        public SweetnessManager(string connectiobString):
            base(connectiobString)
        {
        }
        #endregion

        #region I_DB_MANAGABLE
        public void DeleteData(SweetnessDegree data)
        {
            throw new NotImplementedException();
        }

        public void EditData(SweetnessDegree data)
        {
            throw new NotImplementedException();
        }

        public List<SweetnessDegree> GetData()
        {
            const string queryString = "select * from SweetnessDegree";
            List<SweetnessDegree> result = new List<SweetnessDegree>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new SweetnessDegree((int)reader[0], reader[1] as string));
            return result;
        }

        public void LoadData(SweetnessDegree data)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
