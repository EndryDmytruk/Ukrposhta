namespace Task_042022.MenuForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Departments_Menu_Click(object sender, EventArgs e)
        {
            var newForm = new Departments();
            newForm.ShowDialog();
        }
    }
}