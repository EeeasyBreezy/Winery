using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winery.DataBaseManagers;
using Winery.Instanses;

namespace WineryDatabase.Forms
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            List<Wine> filteredList = null;
            MainForm main = Application.OpenForms["MainForm"] as MainForm;
            switch(FilterComboBox.SelectedIndex)
            {
                case 0:
                    int id = Convert.ToInt32(FilterValueTextBox.Text);
                    filteredList = (from w in main.WineList
                                    where w.Id == id
                                    select w).ToList();
                    main.WineTable.DataSource = filteredList;
                    break;
                case 1:
                    filteredList = (from w in main.WineList
                                    where w.Name.Contains(FilterValueTextBox.Text)
                                    select w).ToList();
                    main.WineTable.DataSource = filteredList;
                    break;
                case 2:
                    int year = Convert.ToInt32(FilterValueTextBox.Text);
                    filteredList = (from w in main.WineList
                                    where w.Year == year
                                    select w).ToList();
                    main.WineTable.DataSource = filteredList;
                    break;
                case 3:
                    double alcohol = Convert.ToDouble(FilterValueTextBox.Text);
                    filteredList = (from w in main.WineList
                                    where w.Alcohol == alcohol
                                    select w).ToList();
                    main.WineTable.DataSource = filteredList;
                    break;
                default:
                    main.WineTable.DataSource = main.WineList;
                    break;
            };
            main.WineTable.Refresh();
            main.WineTable.Update();
            Close();
        }
    }
}
