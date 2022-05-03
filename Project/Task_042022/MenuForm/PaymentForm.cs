using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class PaymentForm : Form
    {
        private readonly PaymentController _controller;
        
        public PaymentForm(ContextDB context)
        {
            InitializeComponent();
            _controller = new PaymentController(context);

            Payment_Label.Text = _controller.GetPayments(null);
            UpdateComboBox();
        }

        private void Departments_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (ComboBox)sender;

            Payment_Label.Text = obj.SelectedIndex == 0 
                ? _controller.GetPayments(null)
                : _controller.GetPayments(obj.Text);
        }

        private void UpdateComboBox()
        {
            Departments_ComboBox.Items.Clear();
            Departments_ComboBox.Items.Insert(0, "Виберіть відділ для фільтрації!");
            Departments_ComboBox.Items.AddRange(_controller.GetDepartments().ToArray());
            Departments_ComboBox.SelectedIndex = 0;
        }
    }
}
