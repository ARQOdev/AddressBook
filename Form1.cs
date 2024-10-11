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



    }
}
