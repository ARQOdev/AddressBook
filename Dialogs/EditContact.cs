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

        public Contact Contact { get; private set; }

        public EditContact()
        {
            InitializeComponent();
            Contact = new Contact();
        }

        public EditContact(Contact contact) : this()
        {
            Contact = contact;
            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtCity.Text = contact.City;
            txtAddress.Text = contact.Address;
            txtPhone.Text = contact.PhoneNumber;
            txtMail.Text = contact.Mail;
            txtDescription.Text = contact.Description;

            this.Text = "კონტაქტის რედაქტირება";
            btnSave.Text = "რედაქტირება";
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
                txtFirstName.BackColor = Color.Red;
                can_save = false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.BackColor = Color.Red;
                can_save = false;
            }

            if (!can_save)
            {
                return;
            }

            if (this.Contact.UID == 0)
            {
                string query = "insert into Person (FIRST_NAME, LAST_NAME, DESCRIPTION, PHONE, MAIL, ADDRESS, CITY_UID) " +
                    "values(@FIRST_NAME, @LAST_NAME, @DESCRIPTION, @PHONE, @MAIL, @ADDRESS, @CITY_UID);";
                Dictionary<string, object> pars = new Dictionary<string, object>();

                pars["FIRST_NAME"] = string.IsNullOrEmpty(txtFirstName.Text) ? "" : txtFirstName.Text;
                pars["LAST_NAME"] = string.IsNullOrEmpty(txtLastName.Text) ? "" : txtLastName.Text;
                pars["DESCRIPTION"] = string.IsNullOrEmpty(txtDescription.Text) ? "" : txtDescription.Text;
                pars["PHONE"] = string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text;
                pars["MAIL"] = string.IsNullOrEmpty(txtMail.Text) ? "" : txtMail.Text;
                pars["ADDRESS"] = string.IsNullOrEmpty(txtAddress.Text) ? "" : txtAddress.Text;
                pars["CITY_UID"] = string.IsNullOrEmpty(txtCity.Text) ? 0 : Contact.CityUID;

                ulong id = DataHelper.ExecuteInsert(query, pars);

                if (id > 0)
                {
                    this.Contact.UID = id;
                    this.Contact.FirstName = string.IsNullOrEmpty(txtFirstName.Text) ? "" : txtFirstName.Text;
                    this.Contact.LastName = string.IsNullOrEmpty(txtLastName.Text) ? "" : txtLastName.Text;
                    this.Contact.City = string.IsNullOrEmpty(txtCity.Text) ? "" : txtCity.Text;
                    this.Contact.Address = string.IsNullOrEmpty(txtAddress.Text) ? "" : txtAddress.Text;
                    this.Contact.PhoneNumber = string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text;
                    this.Contact.Mail = string.IsNullOrEmpty(txtMail.Text) ? "" : txtMail.Text;
                    this.Contact.Description = string.IsNullOrEmpty(txtDescription.Text) ? "" : txtDescription.Text;
                }
                else
                {
                    MessageBox.Show("ვერ მოხერხდა კონტაქტის დამატება!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                string query =  "UPDATE Person SET " +
                                "FIRST_NAME = @FIRST_NAME," +
                                "LAST_NAME = @LAST_NAME," +
                                "DESCRIPTION = @DESCRIPTION," +
                                "PHONE = @PHONE," +
                                "MAIL = @MAIL," +
                                "ADDRESS = @ADDRESS," +
                                "CITY_UID = @CITY_UID " +
                                "WHERE UID = @UID";

                Dictionary<string, object> pars = new Dictionary<string, object>();
                pars["FIRST_NAME"] = string.IsNullOrEmpty(txtFirstName.Text) ? "" : txtFirstName.Text;
                pars["LAST_NAME"] = string.IsNullOrEmpty(txtLastName.Text) ? "" : txtLastName.Text;
                pars["DESCRIPTION"] = string.IsNullOrEmpty(txtDescription.Text) ? "" : txtDescription.Text;
                pars["PHONE"] = string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text;
                pars["MAIL"] = string.IsNullOrEmpty(txtMail.Text) ? "" : txtMail.Text;
                pars["ADDRESS"] = string.IsNullOrEmpty(txtAddress.Text) ? "" : txtAddress.Text;
                pars["CITY_UID"] = string.IsNullOrEmpty(txtCity.Text) ? 0 : Contact.CityUID;
                pars["UID"] = Contact.UID;

                DataHelper.ExecuteQuery(query, pars);

                this.Contact.FirstName = string.IsNullOrEmpty(txtFirstName.Text) ? "" : txtFirstName.Text;
                this.Contact.LastName = string.IsNullOrEmpty(txtLastName.Text) ? "" : txtLastName.Text;
                this.Contact.City = string.IsNullOrEmpty(txtCity.Text) ? "" : txtCity.Text;
                this.Contact.Address = string.IsNullOrEmpty(txtAddress.Text) ? "" : txtAddress.Text;
                this.Contact.PhoneNumber = string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text;
                this.Contact.Mail = string.IsNullOrEmpty(txtMail.Text) ? "" : txtMail.Text;
                this.Contact.Description = string.IsNullOrEmpty(txtDescription.Text) ? "" : txtDescription.Text;
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
            txtFirstName.BackColor = Color.White;
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;
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
