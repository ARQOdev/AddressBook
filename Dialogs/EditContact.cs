﻿using AddressBook.Models;
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
                this.Contact.Description = string.IsNullOrEmpty(txtDescription.Text) ? "" : txtDescription.Text;
                this.Contact.PhoneNumber = string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text;
                this.Contact.Mail = string.IsNullOrEmpty(txtMail.Text) ? "" : txtMail.Text;
                this.Contact.Address = string.IsNullOrEmpty(txtAddress.Text) ? "" : txtAddress.Text;
            }
            else
            {
                MessageBox.Show("ვერ მოხერხდა კონტაქტის დამატება!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
