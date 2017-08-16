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
            reader.Close();
            return result;
        }

        public void LoadData(Wine data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = string.Format(@"insert into Wine (Id, Name, NameEng, Alcohol, Year, Price, 
GrapeSort, Sweetness, SulfurDioxide, SortCategory) values ({0}, '{1}', '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9})",
            data.Id, data.Name, data.NameEng, data.Alcohol, data.Year, data.Price, data.GrapeSort,
            data.Sweetness, data.SulfurDioxide, data.SortCategory);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void EditData(Wine data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format(@"update Wine set
Id = {0}, Name = '{1}', NameEng = '{2}', Alcohol = {3}, Year = {4}, Price = {5}, GrapeSort = {6}, Sweetness = {7}, 
SulfurDioxide = {8}, SortCategory = {9} where Id = {10}", data.Id, data.Name, data.NameEng, 
data.Alcohol.ToString().Replace(',', '.'),data.Year, data.Price.ToString().Replace(',', '.'), 
data.GrapeSort.ToString().Replace(',', '.'), data.Sweetness, data.SulfurDioxide.ToString().Replace(',', '.'), 
data.SortCategory, data.Id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void DeleteData(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("delete from Wine where Id = {0}", id);
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Dispose();
        }
        #endregion
    }
}
