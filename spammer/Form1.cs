using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace spammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label6.Text = "Status: Spamming...";
                timer1.Start();
            }
            else 
            {
                label6.Text = "Status: No Spam Message Provided!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            label6.Text = "Status: Stopping...";
            Thread.Sleep(2111);
            label6.Text = "Status: Waiting...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXITTING...");
            Thread.Sleep(812);
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1212);
            MessageBox.Show("Spammer sucessfully launched!");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "T")
            {
                if (textBox1.Text != "")
                {
                    label6.Text = "Status: Spamming...";
                    timer1.Start();
                }
                else
                {
                    label6.Text = "Status: No Spam Message Provided!";
                }
            }

            if (e.Alt && e.KeyCode.ToString() == "Y")
            {
                timer1.Stop();
                label6.Text = "Status: Stopping...";
                Thread.Sleep(2111);
                label6.Text = "Status: Waiting...";
            }
        }
    }
}
