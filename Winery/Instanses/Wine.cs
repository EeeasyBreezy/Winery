using System.Data.SqlClient;

namespace Winery.Instanses
{
    public sealed class Wine
    {
        #region PROPERTIES
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string NameEng
        {
            get; set;
        }
        public double Alcohol
        {
            get; set;
        } 
        public int Year
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }
        public int GrapeSort
        {
            get; set;
        }
        public int Sweetness
        {
            get; set;
        }
        public double SulfurDioxide
        {
            get; set;
        }
        public int SortCategory
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public Wine()
        {
        }
        public Wine(SqlDataReader reader)
        {
            Id = (int)reader[0];
            Name = reader[1] as string;
            NameEng = reader[2] as string;
            Alcohol = (double)reader[3];
            Year = (int)reader[4];
            Price = (double)reader[5];
            GrapeSort = (int)reader[6];
            Sweetness = (int)reader[7];
            SulfurDioxide = (double)reader[8];
            SortCategory = (int)reader[9];
        }
        #endregion

        #region PUBLIC METHODS
        #endregion
    }
}
