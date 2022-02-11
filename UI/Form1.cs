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
using Todolist_SQLITE.UI;

namespace Todolist_SQLITE
{
    public partial class FrmTodo : Form
    {
        public FrmTodo()
        {
            InitializeComponent();
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrEmpty(txtBoxTask.Text))
                {
                    MessageBox.Show("Veuillez renseigner la tâche !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxTask.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxDesc.Text))
                {
                    MessageBox.Show("Veuillez renseigner la Description !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDesc.Focus();
                    return;
                }

                Todo todo = new Todo();
                todo.Task = txtBoxTask.Text;
                todo.Date = dateTimePickerEcheance.Value;
                todo.Description = textBoxDesc.Text;
                _dbContext.Todos.Add(todo);
                if (_dbContext.SaveChanges()>0)
                {
                    MessageBox.Show("Tâche sauvegardée !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show("Tâche non sauvegardée !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void reset()
        {
            txtBoxTask.Text = String.Empty;
            //dateTimePickerEcheance.Value = DateTime;
            textBoxDesc.Text = String.Empty;
            LoadData();
        }

        private void FrmTodo_Load(object sender, EventArgs e)
        {
            try 
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            var todos = _dbContext.GetAll();
            TodoDataGridView.Rows.Clear();
            foreach (var todo in todos)
            {
                TodoDataGridView.Rows.Add(todo.Id, todo.Task, todo.Date, todo.Description);
            }
        }

        private void TodoDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                DataGridViewRow dr = TodoDataGridView.SelectedRows[0];
                frmTodoDetails frm = new frmTodoDetails(this);
                frm.lbl_id_todo.Text = dr.Cells[0].Value.ToString();
                frm.details_txtBoxTask.Text = dr.Cells[1].Value.ToString();
                frm.details_dateTimePicker2.Text = dr.Cells[2].Value.ToString();
                frm.details_textBoxDesc.Text = dr.Cells[3].Value.ToString();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = TodoDataGridView.SelectedRows[0];
                if (MessageBox.Show("Etes vous sûre de vouloir supprimer cette tâche ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _dbContext.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Tâche supprimée avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Supprimée échouée !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
