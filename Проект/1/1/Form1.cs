using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _weapon.Classes; //Плюха для подключения класса из другого файла (!) Запомни

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_2003DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_2003DataSet.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.bd_2003DataSet.test);
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    System.Windows.Vector power = new System.Windows.Vector(20, 30); //Для этого добавил ссылку на widows.Dll иначе не работает
        //    Graphics g = pictureBox1.CreateGraphics();


        //    //---Рамка---------------------------------------------------------------------------------------------------------------------------
        //    int penWidth = 4;
        //    g.DrawRectangle(new Pen(Brushes.Black, 1), penWidth / 2, penWidth / 2, pictureBox1.Width - penWidth, pictureBox1.Height - penWidth); 
        //    //-----------------------------------------------------------------------------------------------------------------------------------
        //    g.DrawLine(new Pen(Brushes.Red, 4), new Point(0, pictureBox1.Height), new Point((int)power.X, (int)power.Y)); //Из за системы координат .NET приходится использовать костыль ввиде pictureBox1.Height - (Желаемый Y, "-" - это как бы плюс)

        //}
    }
}
