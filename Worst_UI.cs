//Made by AnonimKisi

using System;
using System.Windows.Forms;
using System.Threading;

namespace Worst_UI
{
    public partial class Worst_UI : Form
    {
        int length = 1;

        public char RandomName(char letter)
        {
            char[] chars = new char[length];
            int i = 0;
            label1.Text = " ";
            Random random = new Random();
            Goto_Point:
            int random_number = random.Next(1,27);                    
            foreach (char letters in chars)
            {
                while (i < length)
                {
                    i++;                
                    letter = (char)(random_number + 96);
                    label1.Text = label1.Text + letter;
                    Thread.Sleep(20);
                    goto Goto_Point;
                }
            }
            return letter;
        }

        public Worst_UI()
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
