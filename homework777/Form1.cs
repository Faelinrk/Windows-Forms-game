using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework777
{

//а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
    public partial class Form1 : Form
    {
        int comcount = 0;
        int neednum = 0;
        Stack<int> stack = new Stack<int>();
        Random r = new Random(10000);
        public Form1()
        {
            neednum = r.Next(1,2);
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            commandsCount.Text = "Количество отданных команд: 0";
            btnback.Text = "Назад";
            needNum.Text = $"Нужно получить: {neednum}";
            btnReset.Enabled = false;
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
            lblNumber.Enabled = false;
            commandsCount.Enabled = false;
            btnback.Enabled = false;
            needNum.Enabled = false;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            comcount += 1;
            commandsCount.Text = $"Количество отданных команд: {comcount}";
            stack.Push(Int32.Parse(lblNumber.Text));
            checkwin(Int32.Parse(lblNumber.Text), neednum);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            comcount += 1;
            commandsCount.Text = $"Количество отданных команд: {comcount}";
            stack.Push(Int32.Parse(lblNumber.Text));
            checkwin(Int32.Parse(lblNumber.Text), neednum);

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            comcount += 1;
            commandsCount.Text = $"Количество отданных команд: {comcount}";
            stack.Push(Int32.Parse(lblNumber.Text));
            checkwin(Int32.Parse(lblNumber.Text), neednum);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            lblNumber.Enabled = true;
            commandsCount.Enabled = true;
            btnback.Enabled = true;
            btnPlay.Enabled = false;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            comcount += 1;
            commandsCount.Text = $"Количество отданных команд: {comcount}";
            stack.Pop();
            lblNumber.Text = stack.Peek().ToString();
        }

        private void checkwin(int num, int num2)
        {
            if (num == num2)
            {
                MessageBox.Show($"Вы победили за {comcount} ходов!", "Click");
                neednum = r.Next(100, 10000);
                needNum.Text = $"Нужно получить: {neednum}";
            }

        }
    }
}
