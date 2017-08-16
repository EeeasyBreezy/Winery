using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Winery.Instanses;

namespace Winery.DataBaseManagers
{
    public sealed class SearchManager : BaseSqlManager
    {
        #region CONSTRUCTORS
        public SearchManager(string connectionString):
            base(connectionString)
        {
        }
        #endregion

        #region PUBLIC METHODS
        public List<Wine> GetWineOverAvgPrice()
        {
            const string queryString = "select * from Wine where Price >= (select avg(Price) from Wine)";
            List<Wine> result = new List<Wine>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new Wine(reader));
            reader.Close();
            return result;
        }
        public List<GrapeSort> GetGrapeSortWithSugarOverAvr()
        {
            const string queryString = "select * from GrapeSort where Sugar >= (select avg(Sugar) from GrapeSort)";
            List<GrapeSort> result = new List<GrapeSort>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new GrapeSort(reader));
            reader.Close();
            return result;
        }
        public List<GrapeSort> GetGrapeSortsByCountry(int countryId)
        {
            string queryString = string.Format(@"select * from GrapeSort inner join OriginCountry 
                                        on GrapeSort.OriginCountry = OriginCountry.Id
                                        where GrapeSort.OriginCountry = {0}", countryId);
            List<GrapeSort> result = new List<GrapeSort>();
            ExecuteCommand(queryString);
            while (reader.Read())
                result.Add(new GrapeSort(reader));
            reader.Close();
            return result;
        }
        #endregion
    }
}
