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
            filtrebiToolStripMenuItem = new ToolStripMenuItem();
            saxeliToolStripMenuItem = new ToolStripMenuItem();
            gvariToolStripMenuItem = new ToolStripMenuItem();
            qalaqiToolStripMenuItem = new ToolStripMenuItem();
            misamartiToolStripMenuItem = new ToolStripMenuItem();
            elfostaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            contactBindingSource = new BindingSource(components);
            ContacsGrid = new DataGridView();
            uIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityUIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStirpBtnAdd = new ToolStripButton();
            toolStirpBtnEdit = new ToolStripButton();
            toolStirpBtnDelete = new ToolStripButton();
            txtSearch = new TextBox();
            panel1 = new Panel();
            btnFilters = new Button();
            btnClear = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContacsGrid).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile, filtrebiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
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
            MenuEdit.Click += MenuEdit_Click;
            // 
            // MenuDelete
            // 
            MenuDelete.Name = "MenuDelete";
            MenuDelete.Size = new Size(191, 26);
            MenuDelete.Text = "Delete Contact";
            MenuDelete.Click += MenuDelete_Click;
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
            // filtrebiToolStripMenuItem
            // 
            filtrebiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saxeliToolStripMenuItem, gvariToolStripMenuItem, qalaqiToolStripMenuItem, misamartiToolStripMenuItem, elfostaToolStripMenuItem });
            filtrebiToolStripMenuItem.Name = "filtrebiToolStripMenuItem";
            filtrebiToolStripMenuItem.Size = new Size(67, 24);
            filtrebiToolStripMenuItem.Text = "filtrebi";
            // 
            // saxeliToolStripMenuItem
            // 
            saxeliToolStripMenuItem.Name = "saxeliToolStripMenuItem";
            saxeliToolStripMenuItem.Size = new Size(158, 26);
            saxeliToolStripMenuItem.Text = "saxeli";
            saxeliToolStripMenuItem.Click += saxeliToolStripMenuItem_Click;
            // 
            // gvariToolStripMenuItem
            // 
            gvariToolStripMenuItem.Name = "gvariToolStripMenuItem";
            gvariToolStripMenuItem.Size = new Size(158, 26);
            gvariToolStripMenuItem.Text = "gvari";
            gvariToolStripMenuItem.Click += gvariToolStripMenuItem_Click;
            // 
            // qalaqiToolStripMenuItem
            // 
            qalaqiToolStripMenuItem.Name = "qalaqiToolStripMenuItem";
            qalaqiToolStripMenuItem.Size = new Size(158, 26);
            qalaqiToolStripMenuItem.Text = "qalaqi";
            qalaqiToolStripMenuItem.Click += qalaqiToolStripMenuItem_Click;
            // 
            // misamartiToolStripMenuItem
            // 
            misamartiToolStripMenuItem.Name = "misamartiToolStripMenuItem";
            misamartiToolStripMenuItem.Size = new Size(158, 26);
            misamartiToolStripMenuItem.Text = "misamarti";
            misamartiToolStripMenuItem.Click += misamartiToolStripMenuItem_Click;
            // 
            // elfostaToolStripMenuItem
            // 
            elfostaToolStripMenuItem.Name = "elfostaToolStripMenuItem";
            elfostaToolStripMenuItem.Size = new Size(158, 26);
            elfostaToolStripMenuItem.Text = "elfosta";
            elfostaToolStripMenuItem.Click += elfostaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(802, 22);
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
            ContacsGrid.Columns.AddRange(new DataGridViewColumn[] { uIDDataGridViewTextBoxColumn, cityUIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            ContacsGrid.DataSource = contactBindingSource;
            ContacsGrid.Dock = DockStyle.Fill;
            ContacsGrid.Location = new Point(0, 82);
            ContacsGrid.MultiSelect = false;
            ContacsGrid.Name = "ContacsGrid";
            ContacsGrid.ReadOnly = true;
            ContacsGrid.RowHeadersWidth = 51;
            ContacsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContacsGrid.Size = new Size(802, 346);
            ContacsGrid.TabIndex = 2;
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStirpBtnAdd, toolStirpBtnEdit, toolStirpBtnDelete });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(802, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStirpBtnAdd
            // 
            toolStirpBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStirpBtnAdd.Image = Properties.Resources.add_16x16;
            toolStirpBtnAdd.ImageTransparentColor = Color.Magenta;
            toolStirpBtnAdd.Name = "toolStirpBtnAdd";
            toolStirpBtnAdd.Size = new Size(29, 24);
            toolStirpBtnAdd.Text = "toolStripButton1";
            toolStirpBtnAdd.Click += toolStirpBtnAdd_Click;
            // 
            // toolStirpBtnEdit
            // 
            toolStirpBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStirpBtnEdit.Image = Properties.Resources.pencil_16x16;
            toolStirpBtnEdit.ImageTransparentColor = Color.Magenta;
            toolStirpBtnEdit.Name = "toolStirpBtnEdit";
            toolStirpBtnEdit.Size = new Size(29, 24);
            toolStirpBtnEdit.Text = "toolStripButton2";
            toolStirpBtnEdit.Click += toolStirpBtnEdit_Click;
            // 
            // toolStirpBtnDelete
            // 
            toolStirpBtnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStirpBtnDelete.Image = Properties.Resources.clear_16x16;
            toolStirpBtnDelete.ImageTransparentColor = Color.Magenta;
            toolStirpBtnDelete.Name = "toolStirpBtnDelete";
            toolStirpBtnDelete.Size = new Size(29, 24);
            toolStirpBtnDelete.Text = "toolStripButton3";
            toolStirpBtnDelete.Click += toolStirpBtnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(27, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(748, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnFilters);
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 27);
            panel1.TabIndex = 5;
            // 
            // btnFilters
            // 
            btnFilters.Dock = DockStyle.Left;
            btnFilters.Location = new Point(0, 0);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(27, 27);
            btnFilters.TabIndex = 6;
            btnFilters.UseVisualStyleBackColor = true;
            btnFilters.Click += btnFilters_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Right;
            btnClear.Location = new Point(775, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(27, 27);
            btnClear.TabIndex = 5;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(ContacsGrid);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "კონტაქტები";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContacsGrid).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityUIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStirpBtnAdd;
        private ToolStripButton toolStirpBtnEdit;
        private ToolStripButton toolStirpBtnDelete;
        private TextBox txtSearch;
        private ToolStripMenuItem filtrebiToolStripMenuItem;
        private ToolStripMenuItem saxeliToolStripMenuItem;
        private ToolStripMenuItem gvariToolStripMenuItem;
        private ToolStripMenuItem qalaqiToolStripMenuItem;
        private ToolStripMenuItem misamartiToolStripMenuItem;
        private ToolStripMenuItem elfostaToolStripMenuItem;
        private Panel panel1;
        private Button btnFilters;
        private Button btnClear;
    }
}
