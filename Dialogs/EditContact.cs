using AddressBook.Models;
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
    public partial class EditContact : Form
    {

        private Contact Contact { get; set; }

        public EditContact()
        {
            InitializeComponent();
            Contact = new Contact();
        }

        public EditContact(Contact contact) : this()
        {
            Contact = contact;
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool can_save = true;
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.ForeColor = Color.Red;
                can_save = false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.ForeColor = Color.Red;
                can_save = false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.ForeColor = Color.Red;
                can_save = false;
            }

            if (!can_save)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.ForeColor = Color.White;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.ForeColor = Color.White;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.ForeColor = Color.White;
        }

        private void btnSelectCity_Click(object sender, EventArgs e)
        {
            CitySelect form = new CitySelect();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                City? city = form.City;
                if (city != null)
                {
                    Contact.CityUID = city.UID;
                    Contact.City = city.CityName;
                    txtCity.Text = Contact.City;
                }
            }
        }
    }
}
