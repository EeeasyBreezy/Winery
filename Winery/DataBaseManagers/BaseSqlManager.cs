using System.Data.SqlClient;
using System.Data;

namespace Winery.DataBaseManagers
{
    public class BaseSqlManager
    {
        #region DATA
        protected readonly string connectionString;
        protected SqlConnection connection;
        protected SqlDataAdapter adapter;
        protected SqlDataReader reader;
        #endregion

        #region CONSTRUCTORS
        public BaseSqlManager()
        {
        }
        public BaseSqlManager(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        #endregion

        #region PUBLIC METHODS
        public void InitConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        #endregion

        #region PROTECTED METHODS
        protected void ExecuteCommand(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            reader = command.ExecuteReader();
        }

        #endregion
    }
}
