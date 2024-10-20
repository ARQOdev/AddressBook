namespace AddressBook.Dialogs
{
    partial class CitySelect
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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            CityGrid = new DataGridView();
            cityNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnSelect = new Button();
            btnCancel = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CityGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(394, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.add_16x16;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "toolStripButton1";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources.pencil_16x16;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "toolStripButton2";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.clear_16x16;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(29, 24);
            btnDelete.Text = "toolStripButton3";
            btnDelete.Click += btnDelete_Click;
            // 
            // CityGrid
            // 
            CityGrid.AllowUserToAddRows = false;
            CityGrid.AllowUserToDeleteRows = false;
            CityGrid.AutoGenerateColumns = false;
            CityGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CityGrid.Columns.AddRange(new DataGridViewColumn[] { cityNameDataGridViewTextBoxColumn });
            CityGrid.DataSource = cityBindingSource;
            CityGrid.Dock = DockStyle.Fill;
            CityGrid.Location = new Point(0, 27);
            CityGrid.MultiSelect = false;
            CityGrid.Name = "CityGrid";
            CityGrid.ReadOnly = true;
            CityGrid.RowHeadersVisible = false;
            CityGrid.RowHeadersWidth = 51;
            CityGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CityGrid.Size = new Size(394, 160);
            CityGrid.TabIndex = 1;
            CityGrid.DataBindingComplete += CityGrid_DataBindingComplete;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            cityNameDataGridViewTextBoxColumn.HeaderText = "ქალაქი";
            cityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            cityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            cityBindingSource.CurrentChanged += cityBindingSource_CurrentChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 40);
            panel1.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.Location = new Point(190, 5);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "არჩევა";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(294, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "გაუქმება";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CitySelect
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(394, 227);
            Controls.Add(CityGrid);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CitySelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CitySelect";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CityGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView CityGrid;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private BindingSource cityBindingSource;
        private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private Panel panel1;
        private Button btnSelect;
        private Button btnCancel;
    }
}