﻿using AddressBook.Dialogs;
using AddressBook.Models;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        private List<Contact> ContactsList { get; set; }

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
                .Where(l => l.FirstName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            contactBindingSource.DataSource = filteredList;
            ContacsGrid.Refresh();
        }
    }
}
