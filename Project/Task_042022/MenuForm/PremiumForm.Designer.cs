namespace Task_042022.MenuForm
{
    partial class PremiumForm
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
            this.ListPremium_Table = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Value_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListPremium_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(411, 209);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 23);
            this.Exit.TabIndex = 35;
            this.Exit.Text = "Повернутись до меню";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(505, 180);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Очистити";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(411, 180);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 33;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(505, 151);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 32;
            this.Update.Text = "Змінити";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(411, 151);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 31;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Назва\r\nпремії";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Управління преміями";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(411, 93);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Name_TextBox.TabIndex = 27;
            this.Name_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_TextBox_KeyPress);
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Enabled = false;
            this.Id_TextBox.Location = new System.Drawing.Point(411, 64);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Id_TextBox.TabIndex = 26;
            // 
            // ListPremium_Table
            // 
            this.ListPremium_Table.AllowUserToAddRows = false;
            this.ListPremium_Table.AllowUserToDeleteRows = false;
            this.ListPremium_Table.AllowUserToResizeColumns = false;
            this.ListPremium_Table.AllowUserToResizeRows = false;
            this.ListPremium_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListPremium_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPremium_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPremium_Table.Location = new System.Drawing.Point(14, 59);
            this.ListPremium_Table.MultiSelect = false;
            this.ListPremium_Table.Name = "ListPremium_Table";
            this.ListPremium_Table.ReadOnly = true;
            this.ListPremium_Table.RowHeadersVisible = false;
            this.ListPremium_Table.RowTemplate.Height = 25;
            this.ListPremium_Table.ShowEditingIcon = false;
            this.ListPremium_Table.Size = new System.Drawing.Size(327, 237);
            this.ListPremium_Table.TabIndex = 25;
            this.ListPremium_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPremiums_Table_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Значення";
            // 
            // Value_NumericUpDown
            // 
            this.Value_NumericUpDown.Location = new System.Drawing.Point(411, 122);
            this.Value_NumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Value_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_NumericUpDown.Name = "Value_NumericUpDown";
            this.Value_NumericUpDown.Size = new System.Drawing.Size(148, 23);
            this.Value_NumericUpDown.TabIndex = 40;
            this.Value_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "%";
            // 
            // PremiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Value_NumericUpDown);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.ListPremium_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PremiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium";
            ((System.ComponentModel.ISupportInitialize)(this.ListPremium_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_NumericUpDown)).EndInit();
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
        private DataGridView ListPremium_Table;
        private Label label4;
        private NumericUpDown Value_NumericUpDown;
        private Label label5;
    }
}