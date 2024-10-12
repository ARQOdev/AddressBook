namespace AddressBook
{
    partial class Form1
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
            MenuExecQuery = new ToolStripMenuItem();
            MenuSelectQuery = new ToolStripMenuItem();
            MenuUpdateQuery = new ToolStripMenuItem();
            MenuInsertQuery = new ToolStripMenuItem();
            MenuDeleteQuery = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            Contacts = new DataGridView();
            cityBindingSource = new BindingSource(components);
            uIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Contacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile, MenuExecQuery });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            // MenuExecQuery
            // 
            MenuExecQuery.DropDownItems.AddRange(new ToolStripItem[] { MenuSelectQuery, MenuUpdateQuery, MenuInsertQuery, MenuDeleteQuery });
            MenuExecQuery.Name = "MenuExecQuery";
            MenuExecQuery.Size = new Size(117, 24);
            MenuExecQuery.Text = "Execute Query";
            // 
            // MenuSelectQuery
            // 
            MenuSelectQuery.Name = "MenuSelectQuery";
            MenuSelectQuery.Size = new Size(141, 26);
            MenuSelectQuery.Text = "Select";
            MenuSelectQuery.Click += MenuSelectQuery_Click;
            // 
            // MenuUpdateQuery
            // 
            MenuUpdateQuery.Name = "MenuUpdateQuery";
            MenuUpdateQuery.Size = new Size(141, 26);
            MenuUpdateQuery.Text = "Update";
            MenuUpdateQuery.Click += MenuUpdateQuery_Click;
            // 
            // MenuInsertQuery
            // 
            MenuInsertQuery.Name = "MenuInsertQuery";
            MenuInsertQuery.Size = new Size(141, 26);
            MenuInsertQuery.Text = "Insert";
            MenuInsertQuery.Click += MenuInsertQuery_Click;
            // 
            // MenuDeleteQuery
            // 
            MenuDeleteQuery.Name = "MenuDeleteQuery";
            MenuDeleteQuery.Size = new Size(141, 26);
            MenuDeleteQuery.Text = "Delete";
            MenuDeleteQuery.Click += MenuDeleteQuery_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Contacts
            // 
            Contacts.AllowUserToAddRows = false;
            Contacts.AllowUserToDeleteRows = false;
            Contacts.AutoGenerateColumns = false;
            Contacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Contacts.Columns.AddRange(new DataGridViewColumn[] { uIDDataGridViewTextBoxColumn, cityNameDataGridViewTextBoxColumn });
            Contacts.DataSource = cityBindingSource;
            Contacts.Dock = DockStyle.Fill;
            Contacts.Location = new Point(0, 28);
            Contacts.Name = "Contacts";
            Contacts.ReadOnly = true;
            Contacts.RowHeadersWidth = 51;
            Contacts.Size = new Size(800, 400);
            Contacts.TabIndex = 2;
            Contacts.CellContentClick += Contacts_CellContentClick;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            uIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            uIDDataGridViewTextBoxColumn.ReadOnly = true;
            uIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            cityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            cityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Contacts);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Contacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
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
        private DataGridView Contacts;
        private ToolStripMenuItem MenuExecQuery;
        private ToolStripMenuItem MenuSelectQuery;
        private ToolStripMenuItem MenuInsertQuery;
        private ToolStripMenuItem MenuDeleteQuery;
        private ToolStripMenuItem MenuUpdateQuery;
        private BindingSource cityBindingSource;
        private DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
    }
}
