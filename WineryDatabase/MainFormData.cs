using System.Collections.Generic;
using Winery.DataBaseManagers;
using Winery.Instanses;

namespace WineryDatabase
{
    public partial class MainForm
    {
        #region DATA LISTS
        private List<Wine> wineList;
        private List<GrapeSort> grapeSortList;
        private List<OriginCountry> countryList;
        private List<SweetnessDegree> sweetnessList;
        private List<SeedlessnessType> seedlessnessList;
        private List<WineSortCategory> sortCategoryList;
        #endregion

        #region SQL MANAGERS
        private WineManager wineManager;
        private SortManager sortManager;
        private SeedlessnessManager seedlessnessManager;
        private CountryManager countryManager;
        private SweetnessManager sweetnessManager;
        private WineSortManager wineSortManager;
        #endregion
    }
}