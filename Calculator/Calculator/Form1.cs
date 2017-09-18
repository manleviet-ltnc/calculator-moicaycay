using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string strFNumber;
        string strOperator;
        decimal dcAnswer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button BtnNumbers = (Button)sender;
            textBox1.Text += BtnNumbers.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += button15.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btnOperators = (Button)sender;
            strOperator = btnOperators.Text;
            strFNumber = textBox1.Text;
        }

        private void bang_Click(object sender, EventArgs e)
        {
            if (strOperator == ("+"))
                dcAnswer = Convert.ToDecimal(strFNumber) +
                    Convert.ToDecimal(textBox1.Text);
            textBox1.Text = Convert.ToString(dcAnswer);
        }
    }
}
