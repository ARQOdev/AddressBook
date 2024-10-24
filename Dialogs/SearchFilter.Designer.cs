namespace AddressBook.Dialogs
{
    partial class SearchFilter
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
            chkBoxFirstName = new CheckBox();
            chkBoxLastName = new CheckBox();
            chkBoxCity = new CheckBox();
            chkBoxAddress = new CheckBox();
            chkBoxPhone = new CheckBox();
            chkBoxMail = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // chkBoxFirstName
            // 
            chkBoxFirstName.AutoSize = true;
            chkBoxFirstName.Checked = true;
            chkBoxFirstName.CheckState = CheckState.Checked;
            chkBoxFirstName.Location = new Point(24, 22);
            chkBoxFirstName.Name = "chkBoxFirstName";
            chkBoxFirstName.Size = new Size(88, 24);
            chkBoxFirstName.TabIndex = 0;
            chkBoxFirstName.Text = "სახელი";
            chkBoxFirstName.UseVisualStyleBackColor = true;
            // 
            // chkBoxLastName
            // 
            chkBoxLastName.AutoSize = true;
            chkBoxLastName.Location = new Point(24, 52);
            chkBoxLastName.Name = "chkBoxLastName";
            chkBoxLastName.Size = new Size(75, 24);
            chkBoxLastName.TabIndex = 1;
            chkBoxLastName.Text = "გვარი";
            chkBoxLastName.UseVisualStyleBackColor = true;
            // 
            // chkBoxCity
            // 
            chkBoxCity.AutoSize = true;
            chkBoxCity.Location = new Point(24, 82);
            chkBoxCity.Name = "chkBoxCity";
            chkBoxCity.Size = new Size(86, 24);
            chkBoxCity.TabIndex = 2;
            chkBoxCity.Text = "ქალაქი";
            chkBoxCity.UseVisualStyleBackColor = true;
            // 
            // chkBoxAddress
            // 
            chkBoxAddress.AutoSize = true;
            chkBoxAddress.Location = new Point(144, 22);
            chkBoxAddress.Name = "chkBoxAddress";
            chkBoxAddress.Size = new Size(113, 24);
            chkBoxAddress.TabIndex = 3;
            chkBoxAddress.Text = "მისამართი";
            chkBoxAddress.UseVisualStyleBackColor = true;
            // 
            // chkBoxPhone
            // 
            chkBoxPhone.AutoSize = true;
            chkBoxPhone.Location = new Point(144, 52);
            chkBoxPhone.Name = "chkBoxPhone";
            chkBoxPhone.Size = new Size(116, 24);
            chkBoxPhone.TabIndex = 4;
            chkBoxPhone.Text = "ტელეფონი";
            chkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // chkBoxMail
            // 
            chkBoxMail.AutoSize = true;
            chkBoxMail.Location = new Point(144, 82);
            chkBoxMail.Name = "chkBoxMail";
            chkBoxMail.Size = new Size(111, 24);
            chkBoxMail.TabIndex = 5;
            chkBoxMail.Text = "ელ-ფოსტა";
            chkBoxMail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(86, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "შენახვა";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 121);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "გაუქმება";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SearchFilter
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(284, 162);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkBoxMail);
            Controls.Add(chkBoxPhone);
            Controls.Add(chkBoxAddress);
            Controls.Add(chkBoxCity);
            Controls.Add(chkBoxLastName);
            Controls.Add(chkBoxFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchFilter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ფილტრის პარამეტრები";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkBoxFirstName;
        private CheckBox chkBoxLastName;
        private CheckBox chkBoxCity;
        private CheckBox chkBoxAddress;
        private CheckBox chkBoxPhone;
        private CheckBox chkBoxMail;
        private Button btnSave;
        private Button btnCancel;
    }
}