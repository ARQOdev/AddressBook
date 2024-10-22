using AddressBook.Dialogs;
using AddressBook.Models;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        private List<Contact> ContactsList { get; set; }
        private List<bool> Filters;

        public MainForm()
        {
            InitializeComponent();
            DataHelper.ConnectionString = @"Data Source=AddressBook.db;Version=3;";
            ContactsList = new List<Contact>();
            Filters = new List<bool> { false, false, false, false, false };
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

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)contactBindingSource.Current;
            EditContact form = new EditContact(contact);
            DialogResult result = form.ShowDialog();

            if (result != DialogResult.OK)
                return;

            ContacsGrid.Refresh();
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            Contact c = (Contact)contactBindingSource.Current;
            DialogResult result = MessageBox.Show(string.Format("გსურთ წაშალოთ {0} {1} კონტაქტებიდან?", c.FirstName, c.LastName), "კონტაქტის ამოშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            string query = "DELETE FROM Person WHERE UID = @UID";
            Dictionary<string, object> pars = new Dictionary<string, object>();
            pars["UID"] = c.UID;

            DataHelper.ExecuteQuery(query, pars);
            contactBindingSource.RemoveCurrent();
            ContacsGrid.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string query = "select p.*, c.CITY from Person p left join City c on p.CITY_UID = c.UID";
            List<ModelBase> list = DataHelper.ExecuteSelect(ModelBase.GetContactList, query);

            ContactsList = new List<Contact>();
            foreach (ModelBase mb in list)
            {
                ContactsList.Add((Contact)mb);
            }

            contactBindingSource.DataSource = ContactsList;
            ContacsGrid.Refresh();
        }

        private void toolStirpBtnAdd_Click(object sender, EventArgs e)
        {
            MenuNew.PerformClick();
        }

        private void toolStirpBtnEdit_Click(object sender, EventArgs e)
        {
            MenuEdit.PerformClick();
        }

        private void toolStirpBtnDelete_Click(object sender, EventArgs e)
        {
            MenuDelete.PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                contactBindingSource.DataSource = ContactsList;
                ContacsGrid.Refresh();
                return;
            }


            List<Contact> filteredList = ContactsList
                .Where(l => (l.FirstName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) & Filters[0]) ||
                            (l.LastName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) & Filters[1]) ||
                            (l.City.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) & Filters[2]) ||
                            (l.Address.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) & Filters[3]) ||
                            (l.Mail.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) & Filters[4]))
                .ToList();

            contactBindingSource.DataSource = filteredList;
            ContacsGrid.Refresh();
        }

        private void saxeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters[0] = !Filters[0];
            if (saxeliToolStripMenuItem.Text == "saxeli")
            {
                saxeliToolStripMenuItem.Text = "SAXELI";
            }
            else
            {
                saxeliToolStripMenuItem.Text = "saxeli";
            }
        }

        private void gvariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters[1] = !Filters[1];
            if (gvariToolStripMenuItem.Text == "gvari")
            {
                gvariToolStripMenuItem.Text = "GVARI";
            }
            else
            {
                gvariToolStripMenuItem.Text = "gvari";
            }
        }

        private void qalaqiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters[2] = !Filters[2];
            if (qalaqiToolStripMenuItem.Text == "qalaqi")
            {
                qalaqiToolStripMenuItem.Text = "QALAQI";
            }
            else
            {
                qalaqiToolStripMenuItem.Text = "qalaqi";
            }
        }

        private void misamartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters[3] = !Filters[3];
            if (misamartiToolStripMenuItem.Text == "misamarti")
            {
                misamartiToolStripMenuItem.Text = "MISAMARTI";
            }
            else
            {
                misamartiToolStripMenuItem.Text = "misamarti";
            }
        }

        private void elfostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters[4] = !Filters[4];
            if (elfostaToolStripMenuItem.Text == "elfosta")
            {
                elfostaToolStripMenuItem.Text = "ELFOSTA";
            }
            else
            {
                elfostaToolStripMenuItem.Text = "elfosta";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            
        }
    }
}