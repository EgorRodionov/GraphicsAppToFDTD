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
            //try
            //{
            //    string LengthObject = LengthObjectTextBox.Text;
            //    string HeightObject = HeightObjectTextBox.Text;
            //    string AnchorPoint = AnchorPointTextBox.Text;

            //    //сохранение введенных данных в массив
            //    string[] objectСharacteristics = new string[] { LengthObject, HeightObject, AnchorPoint };

            //    string filePath = "RectangleСharacteristicsFile.txt";

            //    //передача данных в файл в конец
            //    using (StreamWriter writer = File.AppendText(filePath))
            //    {
            //        //Записываем данные массива в одну строку, разделяя их запятой
            //        string line = string.Join(",", objectСharacteristics);

            //        //записываем строку в файл
            //        writer.WriteLine(line);
            //    }

            //    DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            //    if (dialogForm2 != null)
            //        dialogForm2.BoxForObjectListBox.Items.Add(_selectValue);
            //    this.Hide();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            
            string LengthObject = LengthObjectTextBox.Text;
            string HeightObject = HeightObjectTextBox.Text;
            string CoordinateX = CoordinateXtextBox.Text;
            string CoordinateY = CoordinateYtextBox.Text;

            if(LengthObject == "" || HeightObject == "" || CoordinateX == "" || CoordinateY == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            //список, который хранит характеристики о добавленных прямоугольниках
            List<string[]> RectangleCharacteristics = new List<string[]>();

            string[] Rectangle = new string[4];
            Rectangle[0] = LengthObject;
            Rectangle[1] = HeightObject;
            Rectangle[2] = CoordinateX;
            Rectangle[3] = CoordinateY;
            RectangleCharacteristics.Add(Rectangle); //добавляем в список массив с характеристиками

            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            if (dialogForm2 != null)
                dialogForm2.BoxForObjectListBox.Items.Add(_selectValue);
            this.Hide();
        }
    }
}
