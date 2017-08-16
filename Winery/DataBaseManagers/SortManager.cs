using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public void DeleteData(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("delete from GrapeSort where Id = {0}", id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
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
            reader.Close();
            return result;
        }
        public void LoadData(GrapeSort data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format(@"insert into GrapeSort (Id, Name, Sugar, Acidity, OriginCountry, 
Taste, Seedlessness, AverageBerryWeight) values ({0}, '{1}', {2}, {3}, {4}, '{5}', {6}, {7})",
data.Id, data.Name, data.Sugar, data.Acidity, data.OriginCountry, data.Taste, data.Seedlessness, data.AverageBerrySize);
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Dispose();
        }
        #endregion
    }
}
