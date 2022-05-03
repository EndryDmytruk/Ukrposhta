using DB;
using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class HomeForm : Form
    {
        private readonly HomeController _controller;

        public HomeForm(ContextDB context)
        {
            InitializeComponent();

            _controller = new HomeController(context);

            UpdateTable();
            UpdateComboBox();
        }

        private void Departments_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new DepartmentForm(_controller.GetContextDb());
            newForm.ShowDialog();

            UpdateTable();
            UpdateComboBox();
        }

        private void Positions_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new PositionForm(_controller.GetContextDb());
            newForm.ShowDialog();

            UpdateTable();
        }

        private void Premiums_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new PremiumForm(_controller.GetContextDb());
            newForm.ShowDialog();

            UpdateTable();
        }

        private void Employees_Menu_Click(object sender, EventArgs e)
        {

        }

        private void Payments_Menu_Click(object sender, EventArgs e)
        {

        }

        private void Report_Menu_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            File.WriteAllText(saveFile.FileName, _controller.GetSortedEmployees());
            MessageBox.Show("Файл сохранен");
        }

        private void ListEmployees_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateTable()
        { 
            
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