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
        bool blCheck;
        public Form1()
        {
            InitializeComponent();
        }
        #region Nút âm dương

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
        #endregion

        #region sự kiện bấm các button số
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button BtnNumbers = (Button)sender;
            if (blCheck == true)
            {
                textBox1.ResetText();
            }
            textBox1.Text += BtnNumbers.Text;
            blCheck = false;
        }
        #endregion

        #region Nút .

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            
            textBox1.Text += button15.Text;
        }
        #endregion

        #region sự kiện kích các buttom phép toán
       
        private void button20_Click(object sender, EventArgs e)
        {
            Button btnOperators = (Button)sender;
            strOperator = btnOperators.Text;
            strFNumber = textBox1.Text;
            blCheck = true;
        }
        #endregion

        #region Dấu bằng
        
        private void bang_Click(object sender, EventArgs e)
        {
            if (strOperator == ("+"))
            {
                dcAnswer = Convert.ToDecimal(strFNumber) +
                    Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(dcAnswer);
            }
            else if (strOperator == ("-"))
            {
                dcAnswer = Convert.ToDecimal(strFNumber) -
                       Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(dcAnswer);
            }
            else if (strOperator == ("*"))
            {
                dcAnswer = Convert.ToDecimal(strFNumber) *
                       Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(dcAnswer);
            }
            else if (strOperator == ("/"))
            {
                dcAnswer = Convert.ToDecimal(strFNumber) /
                       Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(dcAnswer);
            }
        }
        #endregion

        #region Xóa
        
        private void xoa_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1, 1);
        }
        #endregion

        #region nút C
        
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }
        #endregion

        #region Nút CE
        
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            strFNumber = " ";
        }
        #endregion

        #region Căn bậc hai
        
        private void can_bac_hai_Click(object sender, EventArgs e)
        {
            double root = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(root); 
        }
        #endregion

        #region Bình phương
        
        private void binh_phuong_Click(object sender, EventArgs e)
        {
            double root = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(root);
        }
        #endregion

        #region Logaric
        
        private void phan_so_Click(object sender, EventArgs e)
        {
            double root = 1 / Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(root);
        }
        #endregion

        #region Phần trăm
        
        private void phan_tram_Click(object sender, EventArgs e)
        {
            double root = 100 * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(root);
        }
        #endregion
    }
}
