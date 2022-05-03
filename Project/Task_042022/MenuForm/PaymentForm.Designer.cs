namespace Task_042022.MenuForm
{
    partial class PaymentForm
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
            this.Departments_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tittle = new System.Windows.Forms.Label();
            this.Payment_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Departments_ComboBox
            // 
            this.Departments_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Departments_ComboBox.Location = new System.Drawing.Point(12, 12);
            this.Departments_ComboBox.Name = "Departments_ComboBox";
            this.Departments_ComboBox.Size = new System.Drawing.Size(403, 23);
            this.Departments_ComboBox.TabIndex = 2;
            this.Departments_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Departments_ComboBox_SelectedIndexChanged);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Tittle.Location = new System.Drawing.Point(12, 83);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(131, 32);
            this.Tittle.TabIndex = 8;
            this.Tittle.Text = "Зарплата:";
            // 
            // Payment_Label
            // 
            this.Payment_Label.AutoSize = true;
            this.Payment_Label.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Payment_Label.Location = new System.Drawing.Point(149, 77);
            this.Payment_Label.Name = "Payment_Label";
            this.Payment_Label.Size = new System.Drawing.Size(29, 40);
            this.Payment_Label.TabIndex = 9;
            this.Payment_Label.Text = "_";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 154);
            this.Controls.Add(this.Payment_Label);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Departments_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Departments_ComboBox;
        private Label Tittle;
        private Label Payment_Label;
    }
}