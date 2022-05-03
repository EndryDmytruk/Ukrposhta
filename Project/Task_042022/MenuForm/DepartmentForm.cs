using Common;
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
    public partial class DepartmentForm : Form
    {
        private readonly DepartmentController _controller;

        public DepartmentForm(ContextDB context)
        {
            InitializeComponent();
            _controller = new DepartmentController(context);

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
            ListDepartments_Table.DataSource = ConvertService.ToDataTable(_controller.GetAll());
            ListDepartments_Table.Sort(ListDepartments_Table.Columns[0], ListSortDirection.Ascending);

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

        private void ListDepartments_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_TextBox.Text = ListDepartments_Table.Rows[e.RowIndex].Cells[0].Value.ToString();
                Name_TextBox.Text = ListDepartments_Table.Rows[e.RowIndex].Cells[1].Value.ToString();
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
