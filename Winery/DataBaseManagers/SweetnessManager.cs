using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
        public void DeleteData(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("delete from SweetnessDegree where Id = {0}", id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void EditData(SweetnessDegree data)
        {
        }

        public List<SweetnessDegree> GetData()
        {
            const string queryString = "select * from SweetnessDegree";
            List<SweetnessDegree> result = new List<SweetnessDegree>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new SweetnessDegree((int)reader[0], reader[1] as string));
            reader.Close();
            return result;
        }

        public void LoadData(SweetnessDegree data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("insert into SweetnessDegree (Id, Degree) values ({0}, '{1}')",
                                                data.Id, data.Degree);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
        #endregion
    }
}
