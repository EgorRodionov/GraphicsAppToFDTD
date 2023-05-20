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
    public partial class IzmenenieTeacherForm : Form
    {
        DB db = new DB();
        public IzmenenieTeacherForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InsertTextInTextBox()
        {
            DataBaseForm dbform = this.Owner as DataBaseForm;
            var selectedRowIndex = dbform.TeacherDataGridView.CurrentCell.RowIndex;
            var textsurname = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var textname = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var textpatronymic = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var textemail = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[4].Value;
            var textConNumber = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[5].Value;

            SurnametextBox.Text = textsurname.ToString();
            NametextBox2.Text = textname.ToString();
            PatronymictextBox3.Text = textpatronymic.ToString();
            EmailtextBox.Text = textemail.ToString();
            ConNumberTextBox.Text = textConNumber.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SurnametextBox.Text != "" && NametextBox2.Text != "" && PatronymictextBox3.Text != "" && EmailtextBox.Text != "" 
                && ConNumberTextBox.Text != "")
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить данные этого преподавателя?", "Изменение", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

                db.openConnection();

                DataBaseForm dbform = this.Owner as DataBaseForm;
                var selectedRowIndex = dbform.TeacherDataGridView.CurrentCell.RowIndex;
                var id = dbform.TeacherDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                var surname = SurnametextBox.Text;
                var name = NametextBox2.Text;
                var patronymic = PatronymictextBox3.Text;
                var email = EmailtextBox.Text;
                var conNumber = ConNumberTextBox.Text;

                string query = $"UPDATE Teacher SET Surname = @surname, Name = @name, Patronymic = @patronymic, " +
                    $"Email = @email, Contact_Number = @conNumber WHERE ID_Teacher = @id";

                SqlCommand command = new SqlCommand(query, db.getconnection());
                command.Parameters.AddWithValue("surname", surname);
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("patronymic", patronymic);
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("conNumber", conNumber);
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                dbform.RefreshDataGridTeacher(dbform.TeacherDataGridView);
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

        private void IzmenenieTeacherForm_Load(object sender, EventArgs e)
        {
            InsertTextInTextBox();
        }
    }
}
