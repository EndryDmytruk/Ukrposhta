namespace Task_042022.MenuForm
{
    partial class DepartmentForm
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
            this.ListDepartments_Table = new System.Windows.Forms.DataGridView();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDepartments_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // ListDepartments_Table
            // 
            this.ListDepartments_Table.AllowUserToAddRows = false;
            this.ListDepartments_Table.AllowUserToDeleteRows = false;
            this.ListDepartments_Table.AllowUserToResizeColumns = false;
            this.ListDepartments_Table.AllowUserToResizeRows = false;
            this.ListDepartments_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListDepartments_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDepartments_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDepartments_Table.Location = new System.Drawing.Point(12, 56);
            this.ListDepartments_Table.MultiSelect = false;
            this.ListDepartments_Table.Name = "ListDepartments_Table";
            this.ListDepartments_Table.ReadOnly = true;
            this.ListDepartments_Table.RowHeadersVisible = false;
            this.ListDepartments_Table.RowTemplate.Height = 25;
            this.ListDepartments_Table.ShowEditingIcon = false;
            this.ListDepartments_Table.Size = new System.Drawing.Size(341, 237);
            this.ListDepartments_Table.TabIndex = 3;
            this.ListDepartments_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDepartments_Table_CellClick);
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Enabled = false;
            this.Id_TextBox.Location = new System.Drawing.Point(409, 61);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Id_TextBox.TabIndex = 4;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(409, 90);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Name_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Управління відділами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Назва\r\nвідділу";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(409, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(503, 119);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 10;
            this.Update.Text = "Змінити";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(409, 148);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(503, 148);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Очистити";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(409, 177);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Повернутись до меню";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 305);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.ListDepartments_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Department";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Departments_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ListDepartments_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ListDepartments_Table;
        private TextBox Id_TextBox;
        private TextBox Name_TextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Add;
        private Button Update;
        private Button Delete;
        private Button Cancel;
        private Button Exit;
    }
}