using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Winery.Instanses;
using System;

namespace Winery.DataBaseManagers
{
    public sealed class WineManager : BaseSqlManager, IDbManagable<Wine>
    {
        #region CONSTRUCTORS
        public WineManager(string connectionString):
            base(connectionString)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        #endregion

        #region PUBLIC METHODS
        public List<Wine> GetData()
        {
            const string commandText = "select * from Wine";
            List<Wine> result = new List<Wine>();
            ExecuteCommand(commandText);
            while (reader.Read())
                result.Add(new Wine(reader));
            return result;
        }

        public void LoadData(Wine data)
        {
            throw new NotImplementedException();
        }

        public void EditData(Wine data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Wine data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
