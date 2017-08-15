using Winery.Instanses;
using System.Data.SqlClient;
using Winery.DataBaseManagers;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WineryDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitSqlManagers();
            LoadData();
        }
    }
}
