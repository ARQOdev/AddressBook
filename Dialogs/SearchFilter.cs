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
    public partial class SearchFilter : Form
    {

        public bool FirstName { get; private set; }
        public bool LastName { get; private set; }
        public bool Cityname { get; private set; }
        public bool Address { get; private set; }
        public bool Phone { get; private set; }
        public bool Mail { get; private set; }


        public SearchFilter()
        {
            InitializeComponent();
        }

        public SearchFilter(List<bool> Filters) : this()
        {
            FirstName = Filters[0];
            LastName = Filters[1];
            Cityname = Filters[2];
            Address = Filters[3];
            Phone = Filters[4];
            Mail = Filters[5];

            chkBoxFirstName.CheckState = Filters[0] ? CheckState.Checked : CheckState.Unchecked;
            chkBoxLastName.CheckState = Filters[1] ? CheckState.Checked : CheckState.Unchecked;
            chkBoxCity.CheckState = Filters[2] ? CheckState.Checked : CheckState.Unchecked;
            chkBoxAddress.CheckState = Filters[3] ? CheckState.Checked : CheckState.Unchecked;
            chkBoxPhone.CheckState = Filters[4] ? CheckState.Checked : CheckState.Unchecked;
            chkBoxMail.CheckState = Filters[5] ? CheckState.Checked : CheckState.Unchecked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FirstName = chkBoxFirstName.Checked;
            LastName = chkBoxLastName.Checked;
            Cityname = chkBoxCity.Checked;
            Address = chkBoxAddress.Checked;
            Phone = chkBoxPhone.Checked;
            Mail = chkBoxMail.Checked;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
