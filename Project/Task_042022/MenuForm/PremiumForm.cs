using Common;
using DB;
using System.ComponentModel;
using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class PremiumForm : Form
    {
        private readonly PremiumController _controller;

        public PremiumForm(ContextDB context)
        {
            InitializeComponent();
            _controller = new PremiumController(context);

            UpdateTable();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var status = _controller.AddRow(Id_TextBox.Text, Name_TextBox.Text, Value_NumericUpDown.Value.ToString());

            _ = status.Code == StatusCode.Ok
                ? MessageBox.Show("Запис доданий", "", MessageBoxButtons.OK)
                : MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);

            UpdateTable();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var status = _controller.UpdateRow(Id_TextBox.Text, Name_TextBox.Text, Value_NumericUpDown.Value.ToString());

            _ = status.Code == StatusCode.Ok
                ? MessageBox.Show("Запис змінено", "", MessageBoxButtons.OK)
                : MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);

            UpdateTable();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Підтвердьте видалення", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            var status = _controller.DeleteRow(Id_TextBox.Text);

            if (status.Code == StatusCode.Exception)
                MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);

            UpdateTable();
        }

        private void UpdateTable()
        {
            ListPremium_Table.DataSource = ConvertService.ToDataTable(_controller.GetAll());
            ListPremium_Table.Sort(ListPremium_Table.Columns[0], ListSortDirection.Ascending);

            ClaerTextBox();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClaerTextBox();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListPremiums_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_TextBox.Text = ListPremium_Table.Rows[e.RowIndex].Cells[0].Value.ToString();
                Name_TextBox.Text = ListPremium_Table.Rows[e.RowIndex].Cells[1].Value.ToString();
                Value_NumericUpDown.Value = Convert.ToDecimal(ListPremium_Table.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void Departments_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void ClaerTextBox()
        {
            Id_TextBox.Text = String.Empty;
            Name_TextBox.Text = String.Empty;
            Value_NumericUpDown.Value = 1;
        }

        private void Name_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsLetter(e.KeyChar))
            {
                Name_TextBox.Text = String.Empty;
                Name_TextBox.Text = e.KeyChar.ToString().ToUpper();
            }
        }
    }
}
