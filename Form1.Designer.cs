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
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            MenuNew = new ToolStripMenuItem();
            MenuEdit = new ToolStripMenuItem();
            MenuDelete = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            Contacts = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Contacts).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile });
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
            MenuNew.Size = new Size(224, 26);
            MenuNew.Text = "New Contact";
            // 
            // MenuEdit
            // 
            MenuEdit.Name = "MenuEdit";
            MenuEdit.Size = new Size(224, 26);
            MenuEdit.Text = "Edit Contact";
            // 
            // MenuDelete
            // 
            MenuDelete.Name = "MenuDelete";
            MenuDelete.Size = new Size(224, 26);
            MenuDelete.Text = "Delete Contact";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(224, 26);
            MenuExit.Text = "Exit";
            MenuExit.Click += MenuExit_Click;
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
            Contacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Contacts.Dock = DockStyle.Fill;
            Contacts.Location = new Point(0, 28);
            Contacts.Name = "Contacts";
            Contacts.RowHeadersWidth = 51;
            Contacts.Size = new Size(800, 400);
            Contacts.TabIndex = 2;
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
    }
}
