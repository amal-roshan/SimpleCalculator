using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class CalculatorDesign : Form
    {
        public CalculatorDesign()
        {
            InitializeComponent();
        }

        float num1, ans=0;
        int count = 0;
        string op;
        Stack<float> stackNum = new Stack<float>();
        Stack<string> stackSymbol = new Stack<string>();
        bool flag = true;

        private void equals_Click(object sender, EventArgs e)
        {
            stackNum.Push(float.Parse(textBox1.Text));
            if (stackNum.Count == 2)
            {
                op = stackSymbol.Pop();
                count = GetOperation(op);
                ComputeCalculation(count);
            }
            textBox1.Clear();
            ans = stackNum.Pop();
            textBox2.Clear();
            textBox2.Text = ans.ToString();
            //stackNum.Push(ans);
            textBox1.Text = ans.ToString();
        }

        public void ComputeCalculation(int count)
        {
            switch (count)
            {
                case 1:
                    num1 = stackNum.Pop();
                    ans = num1 + stackNum.Pop();
                    stackNum.Push(ans);
                    break;
                case 2:
                    num1 = stackNum.Pop();
                    ans = stackNum.Pop()-num1; 
                    stackNum.Push(ans);
                    break;
                case 3:
                    num1 = stackNum.Pop();
                    ans = num1 * stackNum.Pop();
                    stackNum.Push(ans);
                    break;
                case 4:
                    num1 = stackNum.Pop();
                    ans = stackNum.Pop()/num1;
                    stackNum.Push(ans);
                    break;
                default:
                    break;
            }
        }

        public int GetOperation(string op)
            {
                switch (op)
                {
                    case "+":
                        return 1;
                    case "-":
                        return 2;
                    case "X":
                        return 3;
                    case "/":
                        return 4;
                    default:
                        return 0;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox2.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox2.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox2.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox2.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox2.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox2.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox2.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox2.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox2.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox2.Text += 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            stackNum.Push(float.Parse(textBox1.Text));
            if (stackNum.Count == 2)
            {
                op = stackSymbol.Pop();
                count = GetOperation(op);
                ComputeCalculation(count);
            }
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "+";
            stackSymbol.Push(textBox1.Text);
            textBox2.Text += textBox1.Text;
            textBox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            stackNum.Push(float.Parse(textBox1.Text));
            if (stackNum.Count == 2)
            {
                op = stackSymbol.Pop();
                count = GetOperation(op);
                ComputeCalculation(count);
            }
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "-";
            stackSymbol.Push(textBox1.Text);
            textBox2.Text += textBox1.Text;
            textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            stackNum.Push(float.Parse(textBox1.Text));
            if (stackNum.Count == 2)
            {
                op = stackSymbol.Pop();
                count = GetOperation(op);
                ComputeCalculation(count);
            }
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "X";
            stackSymbol.Push(textBox1.Text);
            textBox2.Text += textBox1.Text;
            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            stackNum.Push(float.Parse(textBox1.Text));
            if (stackNum.Count == 2)
            {
                op = stackSymbol.Pop();
                count = GetOperation(op);
                ComputeCalculation(count);
            }
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "/";
            stackSymbol.Push(textBox1.Text);
            textBox2.Text += textBox1.Text;
            textBox1.Clear();
        }

        private void point_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
            textBox2.Text += ".";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            stackNum.Clear();
            stackSymbol.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
