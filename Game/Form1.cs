using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
       
        
        int count = 0; // счетчик ходов
        public Form1()
        {
            InitializeComponent();

            Adder.Enabled = false;
            Multiplyer.Enabled = false;

        }

        private void Adder_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Num.Text); // расшифровка строки из текстбокса
            a += 1; // операция кнопки
            
            Num.Text = a.ToString();

            
            count++; // тик счетчика
           
        }

        private void Multiplyer_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Num.Text); // расшифровка строки из текстбокса
            a *= 2; // операция кнопки
            
            Num.Text = a.ToString();

           
            count++; // тик счетчика
            
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {

            if ((Num.Text) == (Goal.Text))
            {
                Adder.Enabled = false;
                Multiplyer.Enabled = false;
                MessageBox.Show("Всего ходов : " + count, "Победа");
            }
            if (int.Parse(Num.Text) > int.Parse(Goal.Text))
            {
                Adder.Enabled = false;
                Multiplyer.Enabled = false;
                MessageBox.Show("Всего ходов : " + count, "Поражение");
            }
                

        }

        private void Starter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // создание случайного числа
            int g = rnd.Next(2, 1000);
            Goal.Text = g.ToString(); // запись его в текстбокс

            Adder.Enabled = true;
            Multiplyer.Enabled = true;
            tip.Visible = true;
        }
    }
}
