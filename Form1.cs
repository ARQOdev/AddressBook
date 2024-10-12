using AddressBook.Models;
using System.Data.SQLite;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataHelper.ConnectionString = @"Data Source=AddressBook.db;Version=3;";
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSelectQuery_Click(object sender, EventArgs e)
        {
            string query = "select * from CITY;";
            List<ModelBase> list = DataHelper.ExecuteSelect(ModelBase.GetCityList, query);
            List<City> ctList = new List<City>();
            foreach (ModelBase mb in list)
            {
                ctList.Add((City)mb);
            }
            cityBindingSource.DataSource = ctList;
            Contacts.Refresh();
        }

        private void MenuUpdateQuery_Click(object sender, EventArgs e)
        {
            string query = "update City set CITY = @CITY where UID = @UID;";
            // update City set CITY = 'ბათუმი' where UID = 3;
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["CITY"] = "ბათუმი";
            pars["UID"] = 3;
            DataHelper.ExecuteQuery(query, pars);
        }

        private void MenuInsertQuery_Click(object sender, EventArgs e)
        {
            string query = "insert into City (CITY) values (@CITY);";
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["CITY"] = "ზუგდიდი";
            DataHelper.ExecuteQuery(query, pars);
        }

        private void MenuDeleteQuery_Click(object sender, EventArgs e)
        {
            string query = "delete from City where UID = @UID;";
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["UID"] = 2;
            DataHelper.ExecuteQuery(query, pars);
        }

        private void Contacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
