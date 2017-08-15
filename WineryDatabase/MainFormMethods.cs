using System.Data.SqlClient;
using Winery.DataBaseManagers;

namespace WineryDatabase
{
    public partial class MainForm
    {
        private void InitSqlManagers()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ALEX-ПК\\SQLEXPRESS";
            builder.InitialCatalog = "WineryDb";
            builder.IntegratedSecurity = true;
            wineManager = new WineManager(builder.ConnectionString);
            sortManager = new SortManager(builder.ConnectionString);
            countryManager = new CountryManager(builder.ConnectionString);
            seedlessnessManager = new SeedlessnessManager(builder.ConnectionString);
            sweetnessManager = new SweetnessManager(builder.ConnectionString);
            wineSortManager = new WineSortManager(builder.ConnectionString);
        }
        private void LoadData()
        {
            wineList = wineManager.GetData();
            grapeSortList = sortManager.GetData();
            countryList = countryManager.GetData();
            sweetnessList = sweetnessManager.GetData();
            seedlessnessList = seedlessnessManager.GetData();
            sortCategoryList = wineSortManager.GetData();
            WineTable.DataSource = wineList;
            SortTable.DataSource = grapeSortList;
            SweetnessTable.DataSource = sweetnessList;
            SeedlessnessTable.DataSource = seedlessnessList;
            CountryTable.DataSource = countryList;
            WineSortTable.DataSource = sortCategoryList;
        }
    }
}