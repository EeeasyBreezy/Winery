using System.Data.SqlClient;
using Winery.DataBaseManagers;

namespace WineryDatabase
{
    public partial class MainForm
    {
        #region PUBLIC METHODS
        public void UpdateWineTable()
        {
            WineTable.DataSource = null;
            WineTable.Update();
            WineTable.Refresh();
            WineTable.DataSource = WineList;
            WineTable.Refresh();
            WineTable.Update();
        }
        public void UpdateGrapeSortTable()
        {
            GrapeSortTable.DataSource = null;
            GrapeSortTable.Update();
            GrapeSortTable.Refresh();
            GrapeSortTable.DataSource = GrapeSortList;
            GrapeSortTable.Update();
            GrapeSortTable.Refresh();
        }
        public void UpdateSweetnessTypeTable()
        {
            SweetnessTable.DataSource = null;
            SweetnessTable.Update();
            SweetnessTable.Refresh();
            SweetnessTable.DataSource = SweetnessList;
            SweetnessTable.Update();
            SweetnessTable.Refresh();
        }
        public void UpdateSeednesslessTable()
        {
            SeedlessnessTable.DataSource = null;
            SeedlessnessTable.Update();
            SeedlessnessTable.Refresh();
            SeedlessnessTable.DataSource = SeedlessnessList;
            SeedlessnessTable.Update();
            SeedlessnessTable.Refresh();
        }
        public void UpdateOriginCountryTable()
        {
            CountryTable.DataSource = null;
            CountryTable.Update();
            CountryTable.Refresh();
            CountryTable.DataSource = CountryList;
            CountryTable.Update();
            CountryTable.Refresh();
        }
        public void UpdateWineSortTable()
        {
            WineSortTable.DataSource = null;
            WineSortTable.Update();
            WineSortTable.Refresh();
            WineSortTable.DataSource = SortCategoryList;
            WineSortTable.Update();
            WineSortTable.Refresh();
        }
        #endregion

        #region PRIVATE METHODS
        private void InitSqlManagers()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ALEX-ПК\\SQLEXPRESS";
            builder.InitialCatalog = "WineryDb";
            builder.IntegratedSecurity = true;
            WineManager = new WineManager(builder.ConnectionString);
            SortManager = new SortManager(builder.ConnectionString);
            CountryManager = new CountryManager(builder.ConnectionString);
            SeedlessnessManager = new SeedlessnessManager(builder.ConnectionString);
            SweetnessManager = new SweetnessManager(builder.ConnectionString);
            WineSortManager = new WineSortManager(builder.ConnectionString);
        }
        public void LoadAllData()
        {
            WineList = WineManager.GetData();
            GrapeSortList = SortManager.GetData();
            CountryList = CountryManager.GetData();
            SweetnessList = SweetnessManager.GetData();
            SeedlessnessList = SeedlessnessManager.GetData();
            SortCategoryList = WineSortManager.GetData();
            WineTable.DataSource = WineList;
            GrapeSortTable.DataSource = GrapeSortList;
            SweetnessTable.DataSource = SweetnessList;
            SeedlessnessTable.DataSource = SeedlessnessList;
            CountryTable.DataSource = CountryList;
            WineSortTable.DataSource = SortCategoryList;
        }
        #endregion
    }
}