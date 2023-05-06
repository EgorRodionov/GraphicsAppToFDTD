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
    public partial class CharacteristicForEllipsForm : Form
    {
        private string _selectValue;
        public CharacteristicForEllipsForm(string selectValue)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _selectValue = selectValue;
        }

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {
            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            if (dialogForm2 != null)
                dialogForm2.BoxForObjectListBox.Items.Add(_selectValue);
            this.Hide();
        }
    }
}
