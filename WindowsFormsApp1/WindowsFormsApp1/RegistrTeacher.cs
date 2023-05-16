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
    public partial class RegistrTeacher : Form
    {
        DB db = new DB();
        public RegistrTeacher()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
            AcceptButton = btnRegistr;
        }

        //метод для проверки существующего аккаунта
        public Boolean checkuser()
        {
            var login = LoginTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT Login from [Authorization] WHERE Login = @Login";

            SqlCommand command = new SqlCommand(query, db.getconnection());

            db.openConnection();

            command.Parameters.AddWithValue("Login", login);

            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует!");
                return true;
            }
            else
                return false;
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            var surname = SurnameTextBox.Text;
            var name = NameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var login = LoginTextBox.Text;
            var password = PasswordTextBox2.Text;
            var Email = EmailTextBox.Text;
            var ConNumber = ConNumberTextBox.Text;

            if (checkuser())
                return;

            string queryAddInAuthorization = $"BEGIN TRANSACTION; " +
                $"INSERT INTO [Teacher] (Surname, Name, Patronymic, Email, Contact_Number) " +
                $"VALUES (@Surname, @Name, @Patronymic, @Email, @ConNumber); " +
                $"INSERT INTO [Authorization] (ID_Teacher, Login, Password, Is_Teacher, Is_Admin) " +
                $"VALUES ((SELECT ID_Teacher FROM Teacher WHERE Surname = @Surname AND Name = @Name " +
                $"AND Patronymic = @Patronymic), @Login, @Password, 1, 0); " +
                $"COMMIT;";

            SqlCommand command = new SqlCommand(queryAddInAuthorization, db.getconnection());

            db.openConnection();

            command.Parameters.AddWithValue("Surname", surname);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Patronymic", patronymic);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("Email", Email);
            command.Parameters.AddWithValue("ConNumber", ConNumber);

            if (SurnameTextBox.Text == "" || NameTextBox.Text == "" || PatronymicTextBox.Text == "" || 
               EmailTextBox.Text == "" || ConNumberTextBox.Text == "" || LoginTextBox.Text == "" || 
               PasswordTextBox2.Text == "" ||PasswordRetrytextBox.Text == "")
                MessageBox.Show("Некоторые поля не заполнены!", "Ошибка!");
            else if (PasswordRetrytextBox.Text == PasswordTextBox2.Text && command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                this.Close();
            }
            else
                MessageBox.Show("Пароль не совпадает! Аккаунт не создан.", "Ошибка!");
            db.closeConnection();
        }

        private void RegistrTeacher_Load(object sender, EventArgs e)
        {
            PasswordTextBox2.PasswordChar = '*';
            PasswordRetrytextBox.PasswordChar = '*';
            LoginTextBox.MaxLength = 30;
            PasswordTextBox2.MaxLength = 30;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            EmailTextBox.Text = "";
            ConNumberTextBox.Text = "";
            LoginTextBox.Text = "";
            PasswordTextBox2.Text = "";
            PasswordRetrytextBox.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PasswordTextBox2.UseSystemPasswordChar = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PasswordTextBox2.UseSystemPasswordChar = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PasswordRetrytextBox.UseSystemPasswordChar = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PasswordRetrytextBox.UseSystemPasswordChar = false;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void RegistrStudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrStudent student = new RegistrStudent();
            student.ShowDialog();
        }
    }
}
