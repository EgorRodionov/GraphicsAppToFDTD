using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DialogForm1 : Form
    {
        private readonly CheckUser _user;
        public DialogForm1(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
        }

        private void IsAdmin()
        {
            DataBaseBtn.Visible = _user.IsAdmin;
            RegistrBtn.Visible = _user.IsAdmin;
        }

        private void DialogForm1_Load(object sender, EventArgs e)
        {
            RoleLabel2.Text = $"{_user.Status()}";
            Loginlabel2.Text = $"{_user.Login}";
            IsAdmin();
        }

        private void StartExperimentBtn_Click(object sender, EventArgs e)
        {
            DialogForm2 dialogForm2 = new DialogForm2(_user);
            //this.Hide();
            dialogForm2.ShowDialog();
            //this.Close();
        }

        private void DialogForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Dispose();
            authorization.ShowDialog();
        }

        private void RegistrBtn_Click(object sender, EventArgs e)
        {
            RegistrTeacher registrTeacher = new RegistrTeacher();
            registrTeacher.ShowDialog();
        }

        private void DataBaseBtn_Click(object sender, EventArgs e)
        {
            DataBaseForm dbform = new DataBaseForm();
            dbform.ShowDialog();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("Задачи");
            contextMenuStrip1.Items.Add("О нас");
            contextMenuStrip1.Items.Add("Выйти");
            contextMenuStrip1.Show(menuBtn, new Point(0, menuBtn.Height));
        }

        //Событие которое выполняется при выборе эл-та в меню
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Задачи")
            {
                TaskForm taskForm = new TaskForm(_user);
                taskForm.ShowDialog();
            }
            else if (e.ClickedItem.Text == "О нас")
                MessageBox.Show("Дипломная работа на тему \"Лабораторный практикум для изучения распространения электромагнитных " +
                    "полей в двумерном пространстве.\" \n Выполнил: Родионов Егор Александрович", "О нас!");
            else
                if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

    }
}
