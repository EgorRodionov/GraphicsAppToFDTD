using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class IzmenenieTaskForm : Form
    {
        DB db = new DB();
        public IzmenenieTaskForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InsertTextInTextBox()
        {
            DataBaseForm dbform = this.Owner as DataBaseForm;
            var selectedRowIndex = dbform.TaskDataGridView.CurrentCell.RowIndex;
            var id = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var surname = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var name = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var patronymic = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var TitleTask = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[4].Value;
            var Content = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[5].Value;

            string query = $"SELECT CONCAT(Surname, + ' ' + Name, + ' ' + Patronymic) FROM Student";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                ForStudentComboBox.Items.Add(reader.GetString(0));
            reader.Close();
            db.closeConnection();

            ForStudentComboBox.SelectedItem = surname + " " + name + " " + patronymic;
            TitleTaskTextBox.Text = TitleTask.ToString();
            ContentTextBox.Text = Content.ToString();
        }

        private void IzmenenieTaskForm_Load(object sender, EventArgs e)
        {
            InsertTextInTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ForStudentComboBox.SelectedItem != null && TitleTaskTextBox.Text != "" && ContentTextBox.Text != "")
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить данные этого задания?", "Изменение", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

                db.openConnection();

                DataBaseForm dbform = this.Owner as DataBaseForm;
                var selectedRowIndex = dbform.TaskDataGridView.CurrentCell.RowIndex;
                var id = dbform.TaskDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                var forStudent = ForStudentComboBox.Text;
                var titleTask = TitleTaskTextBox.Text;
                var content = ContentTextBox.Text;

                string query = $"UPDATE Individual_Task SET Student_ID = (SELECT ID_Student FROM Student WHERE CONCAT(Surname, + ' ' + " +
                    $"Name, + ' ' + Patronymic) = @forStudent), Title_Task = @TitleTask, Content = @Content WHERE ID_Task = @id";

                SqlCommand command = new SqlCommand(query, db.getconnection());
                command.Parameters.AddWithValue("forStudent", forStudent);
                command.Parameters.AddWithValue("TitleTask", titleTask);
                command.Parameters.AddWithValue("Content", content);

                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                dbform.RefreshDataGridTask(dbform.TaskDataGridView);
                this.Close();
            }
            else
                MessageBox.Show("Поля должны быть заполнены!", "Ошибка");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
