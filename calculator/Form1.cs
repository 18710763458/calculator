using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string num1 = "";
        string num2 = "";
        decimal result = 0;
        string operChar = "";
        bool flag = false;
        bool flagNum = false;
        public Form1()
        {
            InitializeComponent();
        }
        //关闭应用程序
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        //1-9的按键
        private void button14_Click(object sender, EventArgs e)
        {
            NewMethod(sender);
        }

        private void NewMethod(object sender)
        {
            if (operChar != "" && textBox1.Text != "0." && flagNum == false)
            {
                textBox1.Text = "";
                flagNum = true;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += Convert.ToString(((Button)sender).Text);
            flag = true;
        }

        //按键0
        private void button19_Click(object sender, EventArgs e)
        {
            if (operChar != "" && flagNum == false)
            {
                textBox1.Text = "";
                flagNum = true;
            }
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                textBox1.Text += Convert.ToString(button19.Text);
            }
            else
            {
                textBox1.Text = button19.Text;
            }
            flag = true;
        }
        //按键.
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(".") < 0)
            {
                textBox1.Text += button18.Text;
            }
        }
        //清空输入框
        private void button3_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            operChar = "";
            flag = false;
            result = 0;
            textBox1.Text = "0";
        }
        //删除最后一个字符
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }

        }
        //运算符
        private void button5_Click(object sender, EventArgs e)
        {
            if (operChar != "" && flag)
            {
                num2 = textBox1.Text;
            }
            string OperChar = ((Button)sender).Text;
            if (Convert.ToString(num2) != "")
            {
                switch (operChar)
                {
                    case "+":
                        result = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);
                        break;
                    case "-":
                        result = Convert.ToDecimal(num1) - Convert.ToDecimal(num2);
                        break;
                    case "*":
                        result = Convert.ToDecimal(num1) * Convert.ToDecimal(num2);
                        break;
                    case "÷":
                        result = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
                        break;
                }
                if (Convert.ToInt32(result) == result)
                {
                    result = Convert.ToInt32(result);
                }
                num1 = Convert.ToString(result);
                num2 = "";
                operChar = OperChar;
                textBox1.Text = Convert.ToString(result);
                flag = false;
                flagNum = false;
            }
            else
            {
                num1 = textBox1.Text;
                operChar = OperChar;
            }
        }
    }
}

