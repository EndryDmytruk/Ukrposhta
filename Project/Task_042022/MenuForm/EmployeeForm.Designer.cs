namespace Task_042022.MenuForm
{
    partial class EmployeeForm
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
            this.Tittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Lastname_TextBox = new System.Windows.Forms.TextBox();
            this.Adress_TextBox = new System.Windows.Forms.TextBox();
            this.Salary_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Code_TextBox = new System.Windows.Forms.TextBox();
            this.Departments_ComboBox = new System.Windows.Forms.ComboBox();
            this.Position_ComboBox = new System.Windows.Forms.ComboBox();
            this.Premium_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Add_Panel = new System.Windows.Forms.Panel();
            this.Update_Panel = new System.Windows.Forms.Panel();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Phone_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Add_Panel.SuspendLayout();
            this.Update_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Tittle.Location = new System.Drawing.Point(27, 9);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(235, 32);
            this.Tittle.TabIndex = 7;
            this.Tittle.Text = "Новий співробітник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Прізвище";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(73, 394);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 23);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Повернутись до меню";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(94, 93);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Name_TextBox.TabIndex = 2;
            this.Name_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_TextBox_KeyPress);
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(94, 122);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Surname_TextBox.TabIndex = 3;
            this.Surname_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_TextBox_KeyPress);
            // 
            // Lastname_TextBox
            // 
            this.Lastname_TextBox.Location = new System.Drawing.Point(94, 151);
            this.Lastname_TextBox.Name = "Lastname_TextBox";
            this.Lastname_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Lastname_TextBox.TabIndex = 4;
            this.Lastname_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_TextBox_KeyPress);
            // 
            // Adress_TextBox
            // 
            this.Adress_TextBox.Location = new System.Drawing.Point(94, 209);
            this.Adress_TextBox.Name = "Adress_TextBox";
            this.Adress_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Adress_TextBox.TabIndex = 6;
            // 
            // Salary_TextBox
            // 
            this.Salary_TextBox.Location = new System.Drawing.Point(94, 296);
            this.Salary_TextBox.Name = "Salary_TextBox";
            this.Salary_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Salary_TextBox.TabIndex = 31;
            this.Salary_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ім\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "По батькові";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Адреса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Код";
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Location = new System.Drawing.Point(94, 64);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Code_TextBox.TabIndex = 1;
            this.Code_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code_TextBox_KeyPress);
            // 
            // Departments_ComboBox
            // 
            this.Departments_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Departments_ComboBox.Location = new System.Drawing.Point(94, 238);
            this.Departments_ComboBox.Name = "Departments_ComboBox";
            this.Departments_ComboBox.Size = new System.Drawing.Size(169, 23);
            this.Departments_ComboBox.TabIndex = 39;
            // 
            // Position_ComboBox
            // 
            this.Position_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Position_ComboBox.Location = new System.Drawing.Point(94, 267);
            this.Position_ComboBox.Name = "Position_ComboBox";
            this.Position_ComboBox.Size = new System.Drawing.Size(169, 23);
            this.Position_ComboBox.TabIndex = 40;
            // 
            // Premium_ComboBox
            // 
            this.Premium_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Premium_ComboBox.Location = new System.Drawing.Point(94, 325);
            this.Premium_ComboBox.Name = "Premium_ComboBox";
            this.Premium_ComboBox.Size = new System.Drawing.Size(169, 23);
            this.Premium_ComboBox.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Посада";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Відділ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "Оклад";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Премія";
            // 
            // Add_Panel
            // 
            this.Add_Panel.Controls.Add(this.Add_Button);
            this.Add_Panel.Location = new System.Drawing.Point(94, 354);
            this.Add_Panel.Name = "Add_Panel";
            this.Add_Panel.Size = new System.Drawing.Size(169, 34);
            this.Add_Panel.TabIndex = 46;
            // 
            // Update_Panel
            // 
            this.Update_Panel.Controls.Add(this.Update_Button);
            this.Update_Panel.Controls.Add(this.Delete_Button);
            this.Update_Panel.Location = new System.Drawing.Point(94, 354);
            this.Update_Panel.Name = "Update_Panel";
            this.Update_Panel.Size = new System.Drawing.Size(169, 34);
            this.Update_Panel.TabIndex = 48;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(0, 0);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(71, 23);
            this.Update_Button.TabIndex = 48;
            this.Update_Button.Text = "Змінити";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(98, 0);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(71, 23);
            this.Delete_Button.TabIndex = 47;
            this.Delete_Button.Text = "Видалити";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(98, 0);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(71, 23);
            this.Add_Button.TabIndex = 47;
            this.Add_Button.Text = "Додати";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(94, 180);
            this.Phone_TextBox.Mask = "+38(000)000-00-00";
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.ResetOnSpace = false;
            this.Phone_TextBox.Size = new System.Drawing.Size(169, 23);
            this.Phone_TextBox.TabIndex = 5;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 429);
            this.Controls.Add(this.Update_Panel);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.Add_Panel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Premium_ComboBox);
            this.Controls.Add(this.Position_ComboBox);
            this.Controls.Add(this.Departments_ComboBox);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salary_TextBox);
            this.Controls.Add(this.Adress_TextBox);
            this.Controls.Add(this.Lastname_TextBox);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Add_Panel.ResumeLayout(false);
            this.Update_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tittle;
        private Label label2;
        private Button Exit;
        private TextBox Name_TextBox;
        private TextBox Surname_TextBox;
        private TextBox Lastname_TextBox;
        private TextBox Adress_TextBox;
        private TextBox Salary_TextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Code_TextBox;
        private ComboBox Departments_ComboBox;
        private ComboBox Position_ComboBox;
        private ComboBox Premium_ComboBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel Add_Panel;
        private Button Add_Button;
        private Panel Update_Panel;
        private Button Update_Button;
        private Button Delete_Button;
        private MaskedTextBox Phone_TextBox;
    }
}