namespace Task_042022.MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Departments_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Positions_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Payments_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Departments_Menu,
            this.Positions_Menu,
            this.Employees_Menu,
            this.Payments_Menu,
            this.Report_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Departments_Menu;
        private ToolStripMenuItem Positions_Menu;
        private ToolStripMenuItem Employees_Menu;
        private ToolStripMenuItem Payments_Menu;
        private ToolStripMenuItem Report_Menu;
    }
}