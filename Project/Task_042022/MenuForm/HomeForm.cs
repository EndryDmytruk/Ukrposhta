using Common;
using DB;
using System.ComponentModel;
using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class HomeForm : Form
    {
        private readonly HomeController _controller;
        private readonly ContextDB _db;

        private string? _activeFilter = null;
        
        public HomeForm(ContextDB context)
        {
            InitializeComponent();

            _db = context;
            _controller = new HomeController(context);

            UpdateTable();
            UpdateComboBox();
        }

        private void Departments_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new DepartmentForm(_db);
            newForm.ShowDialog();

            UpdateComboBox();
            UpdateTable();
        }

        private void Positions_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new PositionForm(_db);
            newForm.ShowDialog();

            UpdateTable();
        }

        private void Premiums_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new PremiumForm(_db);
            newForm.ShowDialog();

            UpdateTable();
        }

        private void Employees_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new EmployeeForm(_db, StateEmployeeForm.NewEmployee, null);
            newForm.ShowDialog();

            if (newForm.GetStatusForm == StatusOperationForm.Add)
                MessageBox.Show("Запис додано успішно!");

            UpdateTable();
        }

        private void Payments_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new PaymentForm(_db);
            newForm.ShowDialog();
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
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(ListEmployees_Table.Rows[e.RowIndex].Cells[0].Value.ToString());

                var newForm = new EmployeeForm(_db, StateEmployeeForm.UpdateEmployee, _controller.GetEmployees(id)!);
                newForm.ShowDialog();

                if (newForm.GetStatusForm == StatusOperationForm.Delete)
                    MessageBox.Show("Запис видалено успішно!");

                if (newForm.GetStatusForm == StatusOperationForm.Update)
                    MessageBox.Show("Запис змінено успішно!");

                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            ListEmployees_Table.DataSource = ConvertService.ToDataTable(_controller.GetEmployees(_activeFilter));
            ListEmployees_Table.Columns[0].Visible = false;
            ListEmployees_Table.Sort(ListEmployees_Table.Columns[1], ListSortDirection.Ascending);
        }

        private void UpdateComboBox()
        {
            _activeFilter = null;

            Departments_ComboBox.Items.Clear();
            Departments_ComboBox.Items.Insert(0, "Виберіть відділ для фільтрації!");
            Departments_ComboBox.Items.AddRange(_controller.GetDepartments().ToArray());
            Departments_ComboBox.SelectedIndex = 0;
        }

        private void Departments_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (ComboBox)sender;
            if (obj.SelectedIndex != 0)
            {
                _activeFilter = obj.Text;
            }
            else
            {
                _activeFilter = null;
            }

            UpdateTable();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
            this.Dispose();
        }
    }
}