using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessnumber
{//*2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Для ввода данных от человека используется элемент TextBox.*/
    public partial class Form1 : Form
    {
        int trycount = 0;
        Random r = new Random();
        int neednum = 0;
        public Form1()
        {
            neednum = r.Next(1, 100);
            InitializeComponent();
            button1.Text = "Угадать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trycount += 1;
            checkNum(int.Parse(textBox1.Text), neednum);
            
        }

        private void checkNum(int num1, int num2)
        {
            if (num1 == num2) { MessageBox.Show($"Вы угадали число за {trycount} попыток", "Click"); trycount = 0; }
            else MessageBox.Show("Вы не угадали число!", "Click");

        }
    }
}
