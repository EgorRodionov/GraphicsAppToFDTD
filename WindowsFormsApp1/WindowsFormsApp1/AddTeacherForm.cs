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
    public partial class AddTeacherForm : Form
    {
        DB db = new DB();
        public AddTeacherForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SurnametextBox.Text != "" && NametextBox2.Text != "" && PatronymictextBox3.Text != "" && EmailtextBox.Text != "" 
                && ConNumberTextBox.Text != "")
            {
                db.openConnection();
                var surname = SurnametextBox.Text;
                var name = NametextBox2.Text;
                var patronymic = PatronymictextBox3.Text;
                var email = EmailtextBox.Text;
                var conNumber = ConNumberTextBox.Text;

                string query = $"INSERT INTO [Teacher] (Surname, Name, Patronymic, Email, Contact_Number) " +
                    $"VALUES (@surname, @name, @patronymic, @email, @conNumber)";

                SqlCommand command = new SqlCommand(query, db.getconnection());
                command.Parameters.AddWithValue("surname", surname);
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("patronymic", patronymic);
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("conNumber", conNumber);

                db.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                DataBaseForm dbfofm = this.Owner as DataBaseForm;
                dbfofm.RefreshDataGridTeacher(dbfofm.TeacherDataGridView);
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
