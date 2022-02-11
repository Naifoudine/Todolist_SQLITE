using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todolist_SQLITE.Models;

namespace Todolist_SQLITE.UI
{
    public partial class frmTodoDetails : Form
    {

        FrmTodo frm;

        public frmTodoDetails(FrmTodo frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(details_txtBoxTask.Text))
                {
                    MessageBox.Show("Veuillez renseigner la tâche !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxTask.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(details_textBoxDesc.Text))
                {
                    MessageBox.Show("Veuillez renseigner la Description !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDesc.Focus();
                    return;
                }

                Todo todo = new Todo();
                todo.Id = Convert.ToInt32(lbl_id_todo.Text);
                todo.Task = details_txtBoxTask.Text;
                todo.Date = details_dateTimePicker2.Value;
                todo.Description = details_textBoxDesc.Text;
                //_dbContext.Todos.Add(todo);
                if (_dbContext.Update(todo))
                {
                    MessageBox.Show("Tâche modifiée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Tâche non modifée !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            var todos = _dbContext.GetAll();
            frm.TodoDataGridView.Rows.Clear();
            foreach (var todo in todos)
            {
                frm.TodoDataGridView.Rows.Add(todo.Id, todo.Task, todo.Date, todo.Description);
            }
        }
    }
}
