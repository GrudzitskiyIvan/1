using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "++++++";
            BackColor = ColorTranslator.FromHtml("#99FF66");
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "******";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor=ColorTranslator.FromHtml("#FF0066");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FF0066");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#FF0066");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FF0066");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
