using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
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
        public void DeleteData(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("delete from SeedlessnessType where Id = {0}", id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void EditData(SeedlessnessType data)
        {
        }

        public List<SeedlessnessType> GetData()
        {
            const string queryString = "select * from SeedlessnessType";
            List<SeedlessnessType> result = new List<SeedlessnessType>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new SeedlessnessType((int)reader[0], reader[1] as string));
            reader.Close();
            return result;
        }

        public void LoadData(SeedlessnessType data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = string.Format("insert into SeedlessnessType (Id, Type) values ({0}, '{1}')",
                                                data.Id, data.Type);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        #endregion
    }
}
