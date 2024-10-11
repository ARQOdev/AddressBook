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
            string query = "insert into City (CITY) values (@CITY);";
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["CITY"] = "ქუთაისი";
            DataHelper.ExecuteQuery(query, pars);
        }
    }
}
