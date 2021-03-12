//Made by AnonimKisi

using System;
using System.Windows.Forms;
using System.Threading;

namespace Worst_UI
{
    public partial class Form1 : Form
    {
        int length = 1;

        public char RandomName(char letter)
        {
            label1.Text = " ";
            Random random = new Random();
            int random_number = random.Next(1,27);
            char[] chars = new char[length];
            int i = 0;
            foreach (char letters in chars)
            {
                while (i < length)
                {
                    i++;                
                    switch (random_number)
                    {
                        case 1:
                            letter = 'a';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 2:
                            letter = 'b';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 3:
                            letter = 'c';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 4:
                            letter = 'd';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 5:
                            letter = 'e';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 6:
                            letter = 'f';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 7:
                            letter = 'g';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 8:
                            letter = 'h';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 9:
                            letter = 'i';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 10:
                            letter = 'j';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 11:
                            letter = 'k';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 12:
                            letter = 'l';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 13:
                            letter = 'm';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 14:
                            letter = 'n';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 15:
                            letter = 'o';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 16:
                            letter = 'p';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 17:
                            letter = 'q';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 18:
                            letter = 'r';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 19:
                            letter = 's';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 20:
                            letter = 't';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 21:
                            letter = 'u';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 22:
                            letter = 'v';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 23:
                            letter = 'w';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 24:
                            letter = 'x';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 25:
                            letter = 'y';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                        case 26:
                            letter = 'z';
                            label1.Text = label1.Text + letter;
                            Thread.Sleep(20);
                            random_number = random.Next(1, 9);
                            break;
                    }                
                }
            }
            return letter;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && length < 5)
            {
                length = length + 1;
                label2.Text = "Length of name: " + length + " letters";
            }else if (length == 5)
            {
                MessageBox.Show("Can't have a name longer than 5 letters");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomName('x');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name has been saved as" + label1.Text + ".");
        }
    }
}
