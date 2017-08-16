using System.Collections.Generic;
using Winery.DataBaseManagers;
using Winery.Instanses;

namespace WineryDatabase
{
    public partial class MainForm
    {
        #region DATA LISTS
        public List<Wine> WineList
        { get; set; }
        public List<GrapeSort> GrapeSortList
        { get; set; }
        public List<OriginCountry> CountryList
        { get; set; }
        public List<SweetnessDegree> SweetnessList
        { get; set; }
        public List<SeedlessnessType> SeedlessnessList
        { get; set; }
        public List<WineSortCategory> SortCategoryList
        { get; set; }
        #endregion

        #region SQL MANAGERS
        public WineManager WineManager
        { get; set; }
        public SortManager SortManager
        { get; set; }
        public SeedlessnessManager SeedlessnessManager
        { get; set; }
        public CountryManager CountryManager
        { get; set; }
        public SweetnessManager SweetnessManager
        { get; set; }
        public WineSortManager WineSortManager
        { get; set; }
        public SearchManager DbSearch
        { get; set; }
        #endregion
    }
}