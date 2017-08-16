using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public void DeleteData(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("delete from OriginCountry where Id = {0}", id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void EditData(OriginCountry data)
        {

        }

        public List<OriginCountry> GetData()
        {
            const string queryString = "select * from OriginCountry";
            List<OriginCountry> result = new List<OriginCountry>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new OriginCountry((int)reader[0], reader[1] as string));
            reader.Close();
            return result;
        }

        public void LoadData(OriginCountry data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = string.Format("insert into OriginCountry (Id, Name) values ({0}, '{1}')",
                                                data.Id, data.Name);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        #endregion
    }
}
