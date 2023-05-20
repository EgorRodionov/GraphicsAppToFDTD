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
    public partial class RegistrStudent : Form
    {
        DB db = new DB();
        public RegistrStudent()
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
            var surname = SurnameTextBox.Text;
            var name = NameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT Login, ID_Student from [Authorization] WHERE Login = @Login OR " +
                $"ID_Student = (SELECT ID_Student FROM Student WHERE Surname = @Surname AND Name = @Name AND Patronymic = @Patronymic)";

            SqlCommand command = new SqlCommand(query, db.getconnection());

            db.openConnection();

            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Surname", surname);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Patronymic", patronymic);

            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким логином или студентом уже существует!");
                return true;
            }
            else
                return false;
        }

        private void RegistrStudent_Load(object sender, EventArgs e)
        {
            AddElementInComboBox();
            PasswordTextBox2.PasswordChar = '*';
            PasswordRetrytextBox.PasswordChar = '*';
            LoginTextBox.MaxLength = 30;
            PasswordTextBox2.MaxLength = 30;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        //метод для загрузки данных в comboBox ForGroup
        private void AddElementInComboBox()
        {
            string query = $"SELECT Title_Group FROM [Group]";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                GroupcomboBox.Items.Add(reader.GetString(0));
            reader.Close();
            db.closeConnection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            EmailTextBox.Text = "";
            GroupcomboBox.SelectedIndex = -1;
            LoginTextBox.Text = "";
            PasswordTextBox2.Text = "";
            PasswordRetrytextBox.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PasswordRetrytextBox.UseSystemPasswordChar = false;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PasswordRetrytextBox.UseSystemPasswordChar = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            var surname = SurnameTextBox.Text;
            var name = NameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var group = GroupcomboBox.Text;
            var email = EmailTextBox.Text;
            var login = LoginTextBox.Text;
            var password = PasswordTextBox2.Text;

            //проверка сущ. аккаунт
            if (checkuser())
                return;

            string queryAddInAuthorization = $"BEGIN TRANSACTION; " +
                $"INSERT INTO [Student] (ID_Group, Surname, Name, Patronymic, Email) " +
                $"VALUES ((SELECT ID_Group FROM [Group] WHERE Title_Group = @TitleGroup), @Surname, @Name, @Patronymic, @Email); " +
                $"INSERT INTO [Authorization] (ID_Student, ID_Group, Login, Password, Is_Teacher, Is_Admin) " +
                $"VALUES ((SELECT ID_Student FROM Student WHERE Surname = @Surname AND Name = @Name " +
                $"AND Patronymic = @Patronymic), (SELECT ID_Group FROM [Group] WHERE Title_Group = @TitleGroup), @Login, @Password, 0, 0); " +
                $"COMMIT;";

            SqlCommand command = new SqlCommand(queryAddInAuthorization, db.getconnection());

            db.openConnection();

            command.Parameters.AddWithValue("Surname", surname);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Patronymic", patronymic);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("TitleGroup", group);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", password);

            if (SurnameTextBox.Text == "" || NameTextBox.Text == "" || PatronymicTextBox.Text == "" || 
                GroupcomboBox.Text == "" || LoginTextBox.Text == "" || PasswordTextBox2.Text == "" || PasswordRetrytextBox.Text == "")
                MessageBox.Show("Некоторые поля не заполнены!", "Ошибка!");
            else if (PasswordRetrytextBox.Text == PasswordTextBox2.Text && command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
            }
            else
                MessageBox.Show("Пароль не совпадает! Аккаунт не создан.", "Ошибка!");
            db.closeConnection();
        }
    }
}
