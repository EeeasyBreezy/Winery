using System.Data.SqlClient;
namespace Winery.Instanses
{
    public sealed class GrapeSort
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
        public double Sugar
        {
            get; set;
        }
        public double Acidity
        {
            get; set;
        }
        public int OriginCountry
        {
            get; set;
        }
        public string Taste
        {
            get; set;
        }
        public int Seedlessness
        {
            get; set;
        }
        public double AverageBerrySize
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public GrapeSort()
        {
        }
        public GrapeSort(SqlDataReader reader)
        {
            Id = (int)reader[0];
            Name = reader[1] as string;
            Sugar = (double)reader[2];
            Acidity = (double)reader[3];
            OriginCountry = (int)reader[4];
            Taste = reader[5] as string;
            Seedlessness = (int)reader[6];
            AverageBerrySize = (double)reader[7];
        }
        #endregion
    }
}
