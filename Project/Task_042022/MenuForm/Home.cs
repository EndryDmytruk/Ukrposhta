using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class Home : Form
    {
        private readonly HomeController controller;

        public Home()
        {
            InitializeComponent();

            UpdateTable();
            controller = new HomeController();
        }

        private void Departments_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new Departments();
            newForm.ShowDialog();
        }

        private void ListEmployees_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Report_Menu_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            File.WriteAllText(saveFile.FileName, controller.GetSortedEmployees());
            MessageBox.Show("Файл сохранен");
        }

        private void UpdateTable()
        { 
            
        }
    }
}