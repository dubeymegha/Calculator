using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total1 = 0;
        double total2 = 0;

        //bool plusbuttonclicked;
        //bool minusbuttonclicked;
        //bool multiplybuttonclicked;
        //bool devidebuttonclicked;
        string var;
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSecond.Text;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThird.Text;
        }

        private void btnForth_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnForth.Text;
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFifth.Text;
        }

        private void btnSixth_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSixth.Text;
        }

        private void btnSeventh_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeventh.Text;
        }

        private void btnEighth_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEighth.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            var = "+";

            //plusbuttonclicked = true;
            //minusbuttonclicked = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {


            switch (var)
            {
                case "+":
                    {
                        total2 = total1 + double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    }
                case "-":
                    {
                        total2 = total1 - double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    }
                case "*":
                    {
                        total2 = total1 * double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    }
                case "/":
                    {
                        total2 = total1 / double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    }
                case "root":
                    {
                        int ans;
                        bool check = false;
                        for (int i = 2; i < total1; i++)
                        {
                            ans = i * i;
                            if(ans==total1)
                            {
                                txtDisplay.Text=(i.ToString());
                                check = true;
                                break;
                            }
                        }
                        if (check == false)
                        {
                            //int i = 0;
                            txtDisplay.Text = "Not a perfect square !!";
                            //MessageBox.Show("Not a perfect square", "Message");
                        }
                        total1 = 0;
                        break;
                    }
            }
            ////if (plusbuttonclicked == true)
            ////{
            ////    total2 = total1 + double.Parse(txtDisplay.Text);
            ////    txtDisplay.Text = total2.ToString();
            ////    total1 = 0;
            ////}
            //if(minusbuttonclicked==true)
            //{
            //    total2 = total1 - double.Parse(txtDisplay.Text);
            //    txtDisplay.Text = total2.ToString();
            //    total1 = 0;
            //}
            //else if(multiplybuttonclicked==true)
            //{
            //    total2 = total1 * double.Parse(txtDisplay.Text);
            //    txtDisplay.Text = total2.ToString();
            //    total1 = 0;
            //}
            //else if(devidebuttonclicked==true)
            //{
            //    total2 = total1 / double.Parse(txtDisplay.Text);
            //    txtDisplay.Text = total2.ToString();
            //    total1 = 0;
            //}
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            var = "-";

            //plusbuttonclicked = false;
            //minusbuttonclicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            var = "*";
            //multiplybuttonclicked = true;
            //plusbuttonclicked = false;
            //minusbuttonclicked = false;
            //devidebuttonclicked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            var = "/";
            //multiplybuttonclicked = false;
            //plusbuttonclicked = false;
            //minusbuttonclicked = false;
            //devidebuttonclicked = true;

        }

        private void sqrRoot_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            var = "root";
        }
    }
}
