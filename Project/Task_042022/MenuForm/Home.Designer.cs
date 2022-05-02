﻿namespace Task_042022.MenuForm
{
    partial class Home
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Departments_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Positions_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Premiums_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Payments_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ListEmployees_Table = new System.Windows.Forms.DataGridView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployees_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Departments_Menu,
            this.Positions_Menu,
            this.Premiums_Menu,
            this.Employees_Menu,
            this.Payments_Menu,
            this.Report_Menu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // Departments_Menu
            // 
            this.Departments_Menu.Name = "Departments_Menu";
            this.Departments_Menu.Size = new System.Drawing.Size(130, 20);
            this.Departments_Menu.Text = "Редагування відділів";
            this.Departments_Menu.Click += new System.EventHandler(this.Departments_Menu_Click);
            // 
            // Positions_Menu
            // 
            this.Positions_Menu.Name = "Positions_Menu";
            this.Positions_Menu.Size = new System.Drawing.Size(122, 20);
            this.Positions_Menu.Text = "Редагування посад";
            // 
            // Premiums_Menu
            // 
            this.Premiums_Menu.Name = "Premiums_Menu";
            this.Premiums_Menu.Size = new System.Drawing.Size(129, 20);
            this.Premiums_Menu.Text = "Редагування премій";
            // 
            // Employees_Menu
            // 
            this.Employees_Menu.Name = "Employees_Menu";
            this.Employees_Menu.Size = new System.Drawing.Size(158, 20);
            this.Employees_Menu.Text = "Додавання співробітника";
            // 
            // Payments_Menu
            // 
            this.Payments_Menu.Name = "Payments_Menu";
            this.Payments_Menu.Size = new System.Drawing.Size(65, 20);
            this.Payments_Menu.Text = "Виплати";
            // 
            // Report_Menu
            // 
            this.Report_Menu.Name = "Report_Menu";
            this.Report_Menu.Size = new System.Drawing.Size(40, 20);
            this.Report_Menu.Text = "Звіт";
            this.Report_Menu.Click += new System.EventHandler(this.Report_Menu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "ФІльтр по відділах";
            // 
            // ListEmployees_Table
            // 
            this.ListEmployees_Table.AllowUserToAddRows = false;
            this.ListEmployees_Table.AllowUserToDeleteRows = false;
            this.ListEmployees_Table.AllowUserToResizeColumns = false;
            this.ListEmployees_Table.AllowUserToResizeRows = false;
            this.ListEmployees_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListEmployees_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListEmployees_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListEmployees_Table.Location = new System.Drawing.Point(12, 56);
            this.ListEmployees_Table.MultiSelect = false;
            this.ListEmployees_Table.Name = "ListEmployees_Table";
            this.ListEmployees_Table.ReadOnly = true;
            this.ListEmployees_Table.RowHeadersVisible = false;
            this.ListEmployees_Table.RowTemplate.Height = 25;
            this.ListEmployees_Table.ShowEditingIcon = false;
            this.ListEmployees_Table.Size = new System.Drawing.Size(776, 382);
            this.ListEmployees_Table.TabIndex = 2;
            this.ListEmployees_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListEmployees_Table_CellClick);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Text files(*.txt)|*.txt";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListEmployees_Table);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployees_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem Departments_Menu;
        private ToolStripMenuItem Positions_Menu;
        private ToolStripMenuItem Employees_Menu;
        private ToolStripMenuItem Payments_Menu;
        private ToolStripMenuItem Report_Menu;
        private ComboBox comboBox1;
        private DataGridView ListEmployees_Table;
        private ToolStripMenuItem Premiums_Menu;
        private SaveFileDialog saveFile;
    }
}