using AddressBook.Dialogs;
using AddressBook.Models;
using System.Data.SQLite;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataHelper.ConnectionString = @"Data Source=AddressBook.db;Version=3;";
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNew_Click(object sender, EventArgs e)
        {
            EditContact form = new EditContact();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                contactBindingSource.Add(form.Contact);
                ContacsGrid.Refresh();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string query = "select p.*, c.CITY from Person p left join City c on p.CITY_UID = c.UID";
            List<ModelBase> list = DataHelper.ExecuteSelect(ModelBase.GetContactList, query);

            List<Contact> contactList = new List<Contact>();
            foreach (ModelBase mb in list)
            {
                contactList.Add((Contact)mb);
            }

            contactBindingSource.DataSource = contactList;
            ContacsGrid.Refresh();
        }
    }
}
