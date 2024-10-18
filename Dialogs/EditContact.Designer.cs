namespace AddressBook.Dialogs
{
    partial class EditContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSelectCity = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(114, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(195, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 15);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(69, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "სახელი:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 48);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(56, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "გვარი:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(114, 45);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(195, 27);
            txtLastName.TabIndex = 2;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 81);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(67, 20);
            lblCity.TabIndex = 5;
            lblCity.Text = "ქალაქი:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(114, 78);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(195, 27);
            txtCity.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 114);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(94, 20);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "მისამართი:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(114, 111);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(351, 27);
            txtAddress.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 147);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "ტელეფონი:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(114, 144);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 8;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(12, 180);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(92, 20);
            lblMail.TabIndex = 11;
            lblMail.Text = "ელ-ფოსტა:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(114, 177);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(195, 27);
            txtMail.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 213);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(82, 20);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "შენიშვნა:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(114, 210);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(351, 58);
            txtDescription.TabIndex = 12;
            // 
            // btnSelectCity
            // 
            btnSelectCity.Image = Properties.Resources.search_24x24;
            btnSelectCity.Location = new Point(315, 78);
            btnSelectCity.Name = "btnSelectCity";
            btnSelectCity.Size = new Size(27, 27);
            btnSelectCity.TabIndex = 14;
            btnSelectCity.UseVisualStyleBackColor = true;
            btnSelectCity.Click += btnSelectCity_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(356, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "დამატება";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(356, 45);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "გაუქმება";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditContact
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(480, 280);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnSelectCity);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "კონტაქტის დამატება";
            Load += EditContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSelectCity;
        private Button btnSave;
        private Button btnCancel;
    }
}