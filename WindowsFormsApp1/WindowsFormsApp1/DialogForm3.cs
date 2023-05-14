using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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

        public List<Figure> Figures = new List<Figure>();

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {
            if (WidthObjectTextBox.Text == "" || HeightObjectTextBox.Text == "" || CoordinateXtextBox.Text == "" || CoordinateYtextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double WidthObject = double.Parse(WidthObjectTextBox.Text);
            double HeightObject = double.Parse(HeightObjectTextBox.Text);
            double CoordinateX = double.Parse(CoordinateXtextBox.Text);
            double CoordinateY = double.Parse(CoordinateYtextBox.Text);

            //передаем данные в класс
            Rectanglee rectanglee = new Rectanglee(CoordinateX, CoordinateY, WidthObject, HeightObject);
            Figures.Add(rectanglee);

            DialogForm2 dialogForm2 = this.Owner as DialogForm2;

            if (dialogForm2 != null)
            {
                foreach (Figure figure in Figures)
                {
                    dialogForm2.BoxForObjectListBox.Items.Add(string.Format("{0}: Ширина: {1}, Высота: {2}, " +
                        "Точка привязки: x = {3} y = {4}", _selectValue, rectanglee.Width, rectanglee.Height, figure.x, figure.y));
                    dialogForm2.Figures.Add(figure);
                }

                ShowShapesOnChart(Figures, rectanglee);
            }
            this.Hide();
        }
        

        // Отображаем фигуры на Chart
        private void ShowShapesOnChart(List<Figure> shapes, Rectanglee rectanglee)
        {
            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            foreach (Figure figure in shapes)
            {
                Series series = new Series();
                series.ChartType = SeriesChartType.Point;
                series.MarkerSize = (int)Math.Max(rectanglee.Width, rectanglee.Height); // задаем размер символа
                series.MarkerStyle = MarkerStyle.Square;
                // Добавляем точку на элемент Chart
                series.Points.AddXY(figure.x, figure.y);
                // Добавляем серию на элемент Chart
                dialogForm2.chart1.Series.Add(series);

            }
        }
    }
}
