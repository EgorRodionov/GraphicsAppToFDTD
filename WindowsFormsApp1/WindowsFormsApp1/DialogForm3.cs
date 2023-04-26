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
    public partial class DialogForm3 : Form
    {
        private string _selectValue;
        public DialogForm3(string selectValue)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _selectValue = selectValue;
        }

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {

        }

        private void DialogForm3_Load(object sender, EventArgs e)
        {
            label1.Text = "Характеристика для " + _selectValue + "а";
        }
    }
}
