using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GameBarley_break
{
    public partial class Form1 : Form
    {
        
       int clickCount = 0;//счетчик кликов
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;//запрет на увеличение и уменьшение формы
            MinimizeBox = false;
            this.Width = 700;//закрепили размер формы
            this.Height = 700;
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            ShuffleLocation();
            DialogResult result = MessageBox.Show("Игра началась! Игрок, у тебя всего 25 попыток, чтобы собрать пятнашки!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        public void ShuffleLocation()//рандомное расположение кнопок
        {
            var rand = new Random();
            var listButton = new[] { button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,button11,button12,button13,button14,button15,button16};
            var shuffledLocations = listButton.Select(r => r.Location)
                                                .OrderBy(x => rand.Next(listButton.Length));
            int i = 0;
            foreach (var loc in shuffledLocations)
                listButton[i++].Location = loc;
           
        }
        private void Winner()//функция победы в случае верного сбора  пятнашек за номером 15,14,13
        {
            foreach (Control control in this.Controls)
            {
                if (button16.Location.X == 327 && button16.Location.Y == 314
                    && button13.Location.X == 30 && button13.Location.Y == 314
                    && button14.Location.X == 129 && button14.Location.Y == 314
                    && button15.Location.X == 228 && button15.Location.Y == 314)
                { 
                    DialogResult result = MessageBox.Show("Победа!!!Игра окончена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
               
                                    }  
            }
           
        }
        private void textBoxCount_TextChanged(object sender, EventArgs e) 
        {
           
        }

        private void GameOver(object sender, MouseEventArgs e)//если много попыток, выводится окно, что пользователь проиграл
        {
          
            if (e.Button == MouseButtons.Left)
            {
                ++clickCount;
                textBoxCount.Text = clickCount.ToString();//отобразит количество попыток
                Winner();
            }
            if (clickCount > 25)
            {
                DialogResult result = MessageBox.Show("Ты проиграл!!!Игра окончена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            
        }

        //события по нажатию на саму кнопку
        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button15.Location.X, button15.Location.Y);
            button15.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
           
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button14.Location.X, button14.Location.Y);
            button14.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button13.Location.X, button13.Location.Y);
            button13.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button12.Location.X, button12.Location.Y);
            button12.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button11.Location.X, button11.Location.Y);
            button11.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button10.Location.X, button10.Location.Y);
            button10.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button9.Location.X, button9.Location.Y);
            button9.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button8.Location.X, button8.Location.Y);
            button8.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button7.Location.X, button7.Location.Y);
            button7.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button6.Location.X, button6.Location.Y);
            button6.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button5.Location.X, button5.Location.Y);
            button5.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button4.Location.X, button4.Location.Y);
            button4.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button3.Location.X, button3.Location.Y);
            button3.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button2.Location.X, button2.Location.Y);
            button2.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new System.Drawing.Point(button16.Location.X, button16.Location.Y);
            button16.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y);
            button1.Location = new System.Drawing.Point(bt.Location.X, bt.Location.Y);
        }
        //события по нажатию мышкой по кнопке
        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }
        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            GameOver(sender, e);
        }

        
    }
    }

