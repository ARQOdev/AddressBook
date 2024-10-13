using AddressBook.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Dialogs
{
    public partial class CitySelect : Form
    {
        public City? City { get; private set; }

        public CitySelect()
        {
            this.City = null;

            InitializeComponent();

            string query = "select * from CITY;";
            List<ModelBase> list = DataHelper.ExecuteSelect(ModelBase.GetCityList, query);
            List<City> ctList = new List<City>();
            foreach (ModelBase mb in list)
            {
                ctList.Add((City)mb);
            }
            cityBindingSource.DataSource = ctList;
            CityGrid.Refresh();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.City = (City)cityBindingSource.Current;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string city_name = Interaction.InputBox("მიუთითეთ ქალაქის სახელი!");
            if (string.IsNullOrEmpty(city_name))
                return;
            
            string query = "insert into City (CITY) values (@CITY);";
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["CITY"] = city_name;
            ulong new_id = DataHelper.ExecuteInsert(query, pars);

            City city = new City();
            city.UID = new_id;
            city.CityName = city_name;

            cityBindingSource.Add(city);
            CityGrid.Refresh();
            CityGrid.Rows[CityGrid.Rows.Count - 1].Selected = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
