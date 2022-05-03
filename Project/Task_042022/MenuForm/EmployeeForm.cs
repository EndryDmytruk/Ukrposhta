using Common;
using DB;
using DB.Entities.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Task_042022.Controllers;
using Task_042022.Model;

namespace Task_042022.MenuForm
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeController _controller;
        public StatusOperationForm GetStatusForm { get; set; }

        public EmployeeForm(ContextDB context, StateEmployeeForm state, EmployeeEdit? activeEmployee)
        {
            InitializeComponent();

            _controller = new EmployeeController(context);
            UpdateComboBox();


            if (state == StateEmployeeForm.NewEmployee)
            {
                Update_Panel.Visible = false;
            }
            else
            {
                Tittle.Text = "Співробітник";
                Tittle.Location = new Point(60, 9);
                Code_TextBox.Enabled = false;
                Add_Panel.Visible = false;
                SetInfoToTextBox(activeEmployee);
            }

            GetStatusForm = StatusOperationForm.Nothing;
        }
        

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Departments_ComboBox.SelectedIndex == 0
                || Position_ComboBox.SelectedIndex == 0
                || Premium_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Виберіть значення з випадаючих списків!", "Error", MessageBoxButtons.OK);
                return;
            }

            var item = new EmployeeEdit()
            {
                Code = Code_TextBox.Text,
                Address = Adress_TextBox.Text,
                Name = Name_TextBox.Text,
                Lastname = Lastname_TextBox.Text,
                Phone = Phone_TextBox.Text,
                Salary = Salary_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Department = Departments_ComboBox.Text,
                Position = Position_ComboBox.Text,
                Premium = Premium_ComboBox.Text
            };

            var context = new ValidationContext(item);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(item, context, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Error", MessageBoxButtons.OK);
                return;
            }

            if (Phone_TextBox.Text == "+38(   )   -  -")
            {
                MessageBox.Show("Поле номер не може бути пустим", "Error", MessageBoxButtons.OK);
                return;
            }

            var status = _controller.AddRow(item);

            if (status.Code == StatusCode.Ok)
            {
                GetStatusForm = StatusOperationForm.Add;
                this.Close();
                return;
            }

            MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (Departments_ComboBox.SelectedIndex == 0
                || Position_ComboBox.SelectedIndex == 0
                || Premium_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Виберіть значення з випадаючих списків!", "Error", MessageBoxButtons.OK);
                return;
            }

            var item = new EmployeeEdit()
            {
                Code = Code_TextBox.Text,
                Address = Adress_TextBox.Text,
                Name = Name_TextBox.Text,
                Lastname = Lastname_TextBox.Text,
                Phone = Phone_TextBox.Text,
                Salary = Salary_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Department = Departments_ComboBox.Text,
                Position = Position_ComboBox.Text,
                Premium = Premium_ComboBox.Text
            };

            var context = new ValidationContext(item);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(item, context, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Error", MessageBoxButtons.OK);
                return;
            }

            if (Phone_TextBox.Text == "+38(   )   -  -")
            {
                MessageBox.Show("Поле номер не може бути пустим", "Error", MessageBoxButtons.OK);
                return;
            }

            var status = _controller.UpdateRow(item);

            if (status.Code == StatusCode.Ok)
            {
                GetStatusForm = StatusOperationForm.Update;
                this.Close();
                return;
            }

            MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Підтвердьте видалення", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            var status = _controller.DeleteRow(Code_TextBox.Text);

            if (status.Code == StatusCode.Ok)
            {
                GetStatusForm = StatusOperationForm.Delete;
                this.Close();
                return;
            }

            MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);
        }

        private void SetInfoToTextBox(EmployeeEdit item)
        {
            Code_TextBox.Text = item!.Code.ToString();
            Name_TextBox.Text = item.Name;
            Surname_TextBox.Text = item.Surname;
            Lastname_TextBox.Text = item.Lastname;
            Phone_TextBox.Text = item.Phone;
            Adress_TextBox.Text = item.Address;
            Salary_TextBox.Text = item.Salary.ToString();
            Departments_ComboBox.SelectedIndex = Departments_ComboBox.Items.IndexOf(item.Department);
            Position_ComboBox.SelectedIndex = Position_ComboBox.Items.IndexOf(item.Position);
            Premium_ComboBox.SelectedIndex = Premium_ComboBox.Items.IndexOf(item.Premium);
        }

        private void UpdateComboBox()
        {
            Departments_ComboBox.Items.Clear();
            Departments_ComboBox.Items.Insert(0, "Виберіть відділ!");
            Departments_ComboBox.Items.AddRange(_controller.GetDepartments().ToArray());
            Departments_ComboBox.SelectedIndex = 0;

            Position_ComboBox.Items.Clear();
            Position_ComboBox.Items.Insert(0, "Виберіть посаду!");
            Position_ComboBox.Items.AddRange(_controller.GetPositions().ToArray());
            Position_ComboBox.SelectedIndex = 0;

            Premium_ComboBox.Items.Clear();
            Premium_ComboBox.Items.Insert(0, "Виберіть тип премії!");
            Premium_ComboBox.Items.AddRange(_controller.GetPremiums().ToArray());
            Premium_ComboBox.SelectedIndex = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Name_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void Salary_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keys = new List<char>() { (Char)Keys.Back, ',', '.' };

            if (!Char.IsDigit(e.KeyChar) && !keys.Any(x => x == e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Code_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
