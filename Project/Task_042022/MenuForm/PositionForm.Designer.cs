namespace Task_042022.MenuForm
{
    partial class PositionForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.ListPosition_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListPosition_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(409, 177);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 23);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "Повернутись до меню";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(503, 148);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Очистити";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(409, 148);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(503, 119);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 21;
            this.Update.Text = "Змінити";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(409, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Назва\r\nпосади";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Управління відділами";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(409, 90);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Name_TextBox.TabIndex = 16;
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Enabled = false;
            this.Id_TextBox.Location = new System.Drawing.Point(409, 61);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Id_TextBox.TabIndex = 15;
            // 
            // ListPosition_Table
            // 
            this.ListPosition_Table.AllowUserToAddRows = false;
            this.ListPosition_Table.AllowUserToDeleteRows = false;
            this.ListPosition_Table.AllowUserToResizeColumns = false;
            this.ListPosition_Table.AllowUserToResizeRows = false;
            this.ListPosition_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListPosition_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPosition_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPosition_Table.Location = new System.Drawing.Point(12, 56);
            this.ListPosition_Table.MultiSelect = false;
            this.ListPosition_Table.Name = "ListPosition_Table";
            this.ListPosition_Table.ReadOnly = true;
            this.ListPosition_Table.RowHeadersVisible = false;
            this.ListPosition_Table.RowTemplate.Height = 25;
            this.ListPosition_Table.ShowEditingIcon = false;
            this.ListPosition_Table.Size = new System.Drawing.Size(341, 237);
            this.ListPosition_Table.TabIndex = 14;
            this.ListPosition_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPositions_Table_CellClick);
            // 
            // PositionForm
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
            this.Controls.Add(this.ListPosition_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position";
            ((System.ComponentModel.ISupportInitialize)(this.ListPosition_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Exit;
        private Button Cancel;
        private Button Delete;
        private Button Update;
        private Button Add;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Name_TextBox;
        private TextBox Id_TextBox;
        private DataGridView ListPosition_Table;
    }
}