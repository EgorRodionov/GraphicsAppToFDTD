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

        public List<Figure> Figures = new List<Figure>();

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {
            if (r1TextBox.Text == "" || r2TextBox.Text == "" || FocalDistanceTextBox.Text == "" || 
                CoordinateXtextBox.Text == "" || CoordinateYtextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double r1 = double.Parse(r1TextBox.Text);
            double r2 = double.Parse(r2TextBox.Text);
            double focalDistance = double.Parse(FocalDistanceTextBox.Text);
            double CoordinateX = double.Parse(CoordinateXtextBox.Text);
            double CoordinateY = double.Parse(CoordinateYtextBox.Text);

            //передаем данные в класс
            Ellipse ellipse = new Ellipse(CoordinateX, CoordinateY, r1, r2, focalDistance);
            Figures.Add(ellipse);

            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            if (dialogForm2 != null)
            {
                foreach (Figure figure in Figures)
                {
                    dialogForm2.BoxForObjectListBox.Items.Add(string.Format("{0}: Большая полуось = {1}, " +
                        "Малая полуось = {2}, Фокальное расстояние = {3}, Точка привязки: x = {4} y = {5}", 
                        _selectValue, r1, r2, focalDistance, CoordinateX, CoordinateY));
                    dialogForm2.Figures.Add(figure);
                }
            }
            this.Hide();
        }
    }
}
