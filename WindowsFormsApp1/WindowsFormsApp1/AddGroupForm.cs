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
    public partial class AddGroupForm : Form
    {
        DB db = new DB();
        public AddGroupForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(TitleGroupTextBox.Text != "")
            {
                var group = TitleGroupTextBox.Text;
                db.openConnection();

                string query = $"INSERT INTO [Group] (Title_Group) VALUES (@TitleGroup)";

                SqlCommand command = new SqlCommand(query, db.getconnection());
                command.Parameters.AddWithValue("TitleGroup", group);

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                DataBaseForm dbfofm = this.Owner as DataBaseForm;
                dbfofm.RefreshDataGridGroups(dbfofm.GroupsDataGridView);
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
