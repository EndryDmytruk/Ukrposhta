using Common;
using DB;
using System.ComponentModel;
using Task_042022.Controllers;

namespace Task_042022.MenuForm
{
    public partial class PositionForm : Form
    {
        private readonly PositionController _controller;

        public PositionForm(ContextDB context)
        {
            InitializeComponent();
            _controller = new PositionController(context);

            UpdateTable();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var status = _controller.AddRow(Id_TextBox.Text, Name_TextBox.Text);

            _ = status.Code == StatusCode.Ok
                ? MessageBox.Show("Запис доданий", "", MessageBoxButtons.OK)
                : MessageBox.Show(status.GetException.Message, "Error", MessageBoxButtons.OK);

            UpdateTable();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var status = _controller.UpdateRow(Id_TextBox.Text, Name_TextBox.Text);

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
            ListPosition_Table.DataSource = ConvertService.ToDataTable(_controller.GetAll());
            ListPosition_Table.Sort(ListPosition_Table.Columns[0], ListSortDirection.Ascending);

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

        private void ListPositions_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_TextBox.Text = ListPosition_Table.Rows[e.RowIndex].Cells[0].Value.ToString();
                Name_TextBox.Text = ListPosition_Table.Rows[e.RowIndex].Cells[1].Value.ToString();
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
        }
    }
}
