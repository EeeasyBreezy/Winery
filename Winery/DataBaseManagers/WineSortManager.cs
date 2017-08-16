using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
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
        public void DeleteData(int id)
        {
        }

        public void EditData(WineSortCategory data)
        {
        }

        public List<WineSortCategory> GetData()
        {
            const string queryString = "select * from WineSortCategory";
            List<WineSortCategory> result = new List<WineSortCategory>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new WineSortCategory((int)reader[0], reader[1] as string));
            reader.Close();
            return result;
        }

        public void LoadData(WineSortCategory data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = string.Format("insert into WineSortCategory (Id, Sort) values ({0}, '{1}')",
                                                data.Id, data.Sort);
            command.ExecuteNonQuery();
        }
        #endregion
    }
}
