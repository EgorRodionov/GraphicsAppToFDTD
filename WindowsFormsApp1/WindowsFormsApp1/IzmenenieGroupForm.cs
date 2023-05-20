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
    public partial class IzmenenieGroupForm : Form
    {
        DB db = new DB();
        public IzmenenieGroupForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InsertTextInTextBox()
        {
            DataBaseForm dbform = this.Owner as DataBaseForm;
            var selectedRowIndex = dbform.GroupsDataGridView.CurrentCell.RowIndex;
            var titleGroup = dbform.GroupsDataGridView.Rows[selectedRowIndex].Cells["Title_Group"].Value;

            TitleGroupTextBox.Text = titleGroup.ToString();
        }

        private void IzmenenieGroupForm_Load(object sender, EventArgs e)
        {
            InsertTextInTextBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(TitleGroupTextBox.Text != "")
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить данные этой группы?", "Изменение", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

                DataBaseForm dbform = this.Owner as DataBaseForm;
                var selectedRowIndex = dbform.GroupsDataGridView.CurrentCell.RowIndex;
                var id = dbform.GroupsDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                var group = TitleGroupTextBox.Text;

                db.openConnection();

                string query = $"UPDATE [Group] SET Title_Group = @TitleGroup WHERE ID_Group = @id";

                SqlCommand command = new SqlCommand(query, db.getconnection());
                command.Parameters.AddWithValue("TitleGroup", group);
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                dbform.RefreshDataGridGroups(dbform.GroupsDataGridView);
                this.Close();
            }
            else
                MessageBox.Show("Поля должны быть заполнены!", "Ошибка");
        }
    }
}
