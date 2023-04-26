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
        public DialogForm1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
        }

        private void StartExperimentBtn_Click(object sender, EventArgs e)
        {
            DialogForm2 dialogForm2 = new DialogForm2();
            this.Hide();
            dialogForm2.ShowDialog();
            this.Close();
        }
    }
}
