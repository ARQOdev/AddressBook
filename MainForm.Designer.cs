namespace AddressBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            MenuNew = new ToolStripMenuItem();
            MenuEdit = new ToolStripMenuItem();
            MenuDelete = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            contactBindingSource = new BindingSource(components);
            ContacsGrid = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityUIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContacsGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(803, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuNew, MenuEdit, MenuDelete, toolStripSeparator1, MenuExit });
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new Size(46, 24);
            MenuFile.Text = "File";
            // 
            // MenuNew
            // 
            MenuNew.Name = "MenuNew";
            MenuNew.Size = new Size(191, 26);
            MenuNew.Text = "New Contact";
            MenuNew.Click += MenuNew_Click;
            // 
            // MenuEdit
            // 
            MenuEdit.Name = "MenuEdit";
            MenuEdit.Size = new Size(191, 26);
            MenuEdit.Text = "Edit Contact";
            // 
            // MenuDelete
            // 
            MenuDelete.Name = "MenuDelete";
            MenuDelete.Size = new Size(191, 26);
            MenuDelete.Text = "Delete Contact";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(191, 26);
            MenuExit.Text = "Exit";
            MenuExit.Click += MenuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(803, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Models.Contact);
            // 
            // ContacsGrid
            // 
            ContacsGrid.AllowUserToAddRows = false;
            ContacsGrid.AllowUserToDeleteRows = false;
            ContacsGrid.AutoGenerateColumns = false;
            ContacsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContacsGrid.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, cityUIDDataGridViewTextBoxColumn, uIDDataGridViewTextBoxColumn });
            ContacsGrid.DataSource = contactBindingSource;
            ContacsGrid.Dock = DockStyle.Fill;
            ContacsGrid.Location = new Point(0, 28);
            ContacsGrid.Name = "ContacsGrid";
            ContacsGrid.ReadOnly = true;
            ContacsGrid.RowHeadersWidth = 51;
            ContacsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContacsGrid.Size = new Size(803, 400);
            ContacsGrid.TabIndex = 2;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "სახელი";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "გვარი";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "ტელეფონი";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            mailDataGridViewTextBoxColumn.HeaderText = "ელ-ფოსტა";
            mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "ქალაქი";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "მისამართი";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "შენიშვნა";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityUIDDataGridViewTextBoxColumn
            // 
            cityUIDDataGridViewTextBoxColumn.DataPropertyName = "CityUID";
            cityUIDDataGridViewTextBoxColumn.HeaderText = "CityUID";
            cityUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityUIDDataGridViewTextBoxColumn.Name = "cityUIDDataGridViewTextBoxColumn";
            cityUIDDataGridViewTextBoxColumn.ReadOnly = true;
            cityUIDDataGridViewTextBoxColumn.Visible = false;
            cityUIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            uIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            uIDDataGridViewTextBoxColumn.ReadOnly = true;
            uIDDataGridViewTextBoxColumn.Visible = false;
            uIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(ContacsGrid);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContacsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuNew;
        private ToolStripMenuItem MenuEdit;
        private ToolStripMenuItem MenuDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuExit;
        private StatusStrip statusStrip1;
        private BindingSource contactBindingSource;
        private DataGridView ContacsGrid;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityUIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
    }
}
