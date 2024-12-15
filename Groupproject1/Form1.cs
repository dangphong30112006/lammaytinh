using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //khai bao bien
        float data1, data2, ketqua;
        string pheptinh;
        bool isNegative = false;
        bool isPercent = false;

        //button number 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 8)
            {
                mangduoi.Text = "-8";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "8";
            }
        }
        //button number 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 9)
            {
                mangduoi.Text = "-9";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "9";
            }
        }
        //button number 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 4)
            {
                mangduoi.Text = "-4";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "4";
            }
        }
        //button number 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 5)
            {
                mangduoi.Text = "-5";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "5";
            }
        }
        //button number 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 6)
            {
                mangduoi.Text = "-6";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "6";
            }
        }
        //button number 1
        private void btn1_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 1)
            {
                mangduoi.Text = "-1";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "1";
            }
        }
        //button number 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 2)
            {
                mangduoi.Text = "-2";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "2";
            }
        }
        //button number 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 3)
            {
                mangduoi.Text = "3";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "3";
            }
        }
        //button number 0
        private void btn0_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 0)
            {
                mangduoi.Text = "-0";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "0";
            }
        }
        //button cộng
        private void btncong_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                pheptinh = "cong";
                data1 = float.Parse(mangduoi.Text);

                mangduoi.Text = data1.ToString() + " +";
                mangduoi.Clear();
                isNegative = false;
            }
        }
        //button tru
        private void btntru_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                pheptinh = "tru";
                data1 = float.Parse(mangduoi.Text);
                mangduoi.Text = data1.ToString() + " - ";
                mangduoi.Clear();
                isNegative = false;
            }
            else
            {
                isNegative = true;
            }
        }
        //button nhân
        private void btnx_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                pheptinh = "nhan";
                data1 = float.Parse(mangduoi.Text);
                mangduoi.Text = data1.ToString() + " x";
                mangduoi.Clear();
                isNegative = false;
            }
        }
        //button chia
        private void btnchia_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                pheptinh = "chia";
                data1 = float.Parse(mangduoi.Text);
                mangduoi.Text = data1.ToString() + " /";
                mangduoi.Clear();
                isNegative = false;
            }
        }
        //button x^y
        private void btnxmuy_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                pheptinh = "x^y";
                data1 = float.Parse(mangduoi.Text);
                mangduoi.Text = data1.ToString() + " ^";
                mangduoi.Clear();
                isNegative = false;
            }
        }
        //button mũ 2
        private void btnxmu2_Click(object sender, EventArgs e)
        {

            if (mangduoi.Text.Length > 0)
            {

                data1 = float.Parse(mangduoi.Text);
                data2 = (float)Math.Pow(data1, 2);
                //them vao listbox
                history.Items.Add(data1.ToString() + " ^2 " + " = " + data2.ToString());
                mangiua.Text = data1.ToString() + "^2 =";
                mangduoi.Text = data2.ToString();
            }
        }
        //button căng bậc 2
        private void btncangx_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                data1 = float.Parse(mangduoi.Text);
                if (data1 >= 0)
                {
                    data2 = (float)Math.Sqrt(data1);
                    //them vao listbox
                    history.Items.Add(" √" + data1.ToString() + " = " + data2.ToString());
                    mangiua.Text = "√" + data1.ToString() + " =";
                    mangduoi.Text = data2.ToString();
                }
                else
                {
                    mangtren.Text = "khong can bac hai voi so nho hon 0";
                    mangduoi.Clear();
                }
            }
        }
        //button clear
        private void btnc_Click(object sender, EventArgs e)
        {
            mangduoi.Clear();
            mangtren.Clear();
            mangiua.Clear();
            pheptinh = "";
            data1 = 0;
            data2 = 0;
            isNegative = false;
        }
        //button %
        private void btnphantram_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                // neu dang hien % thi chuyen ve decimal
                if (mangduoi.Text.EndsWith("%"))
                {
                    string numStr = mangduoi.Text.TrimEnd('%');
                    data1 = float.Parse(numStr) / 100;
                    mangiua.Text = numStr + "% to dec =";
                    mangduoi.Text = data1.ToString();
                    isPercent = true;
                }
                // chua hien % thi chuyen sang %
                else
                {
                    data1 = float.Parse(mangduoi.Text);
                    data2 = data1 * 100;
                    mangiua.Text = data1.ToString() + " to % =";
                    mangduoi.Text = data2.ToString() + "%";
                    isPercent = true;
                }
            }
        }
        //button xoa 1 gia tri
        private void btnac_Click(object sender, EventArgs e)
        {
            if (mangduoi.Text.Length > 0)
            {
                mangduoi.Text = mangduoi.Text.Remove(mangduoi.Text.Length - 1);
            }
        }
        // button bang
        private void btnbang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mangduoi.Text) || string.IsNullOrEmpty(pheptinh))
            {

                return;
            }

            switch (pheptinh)
            {
                case "cong":
                    data2 = data1 + float.Parse(mangduoi.Text);
                    //them vao listbox
                    history.Items.Add(data1.ToString() + " + " + (float.Parse(mangduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    mangiua.Text = data1.ToString() + " + " + float.Parse(mangduoi.Text) + " =";
                    mangduoi.Text = data2.ToString();
                    pheptinh = "";


                    break;
                case "tru":
                    data2 = data1 - float.Parse(mangduoi.Text);
                    //them vao listbox
                    history.Items.Add(data1.ToString() + " - " + (float.Parse(mangduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    mangiua.Text = data1.ToString() + " - " + float.Parse(mangduoi.Text) + " =";
                    mangduoi.Text = data2.ToString();
                    pheptinh = "";
                    break;
                case "nhan":
                    data2 = data1 * float.Parse(mangduoi.Text);
                    //them vao listbox
                    history.Items.Add(data1.ToString() + " * " + (float.Parse(mangduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    mangduoi.Text = data1.ToString() + " x " + float.Parse(mangduoi.Text) + " =";
                    mangduoi.Text = data2.ToString();
                    pheptinh = "";
                    break;
                case "chia":
                    if (float.Parse(mangduoi.Text) == 0)
                    {
                        mangtren.Text = "không chia được với số 0";
                        //hien thi phep tinh o man hinh tren
                        mangiua.Text = data1.ToString() + " / " + float.Parse(mangduoi.Text) + " =";
                    }
                    else
                    {
                        data2 = data1 / float.Parse(mangduoi.Text);
                        //them vao listbox
                        history.Items.Add(data1.ToString() + " / " + (float.Parse(mangduoi.Text)) + " = " + data2.ToString());
                        //hien thi phep tinh o man hinh tren
                        mangiua.Text = data1.ToString() + " / " + float.Parse(mangduoi.Text) + " =";
                        mangduoi.Text = data2.ToString();
                        pheptinh = "";
                    }
                    break;
                case "x^y":
                    data2 = (float)Math.Pow(data1, float.Parse(mangduoi.Text));
                    //them vao listbox
                    history.Items.Add(data1.ToString() + " ^ " + (float.Parse(mangduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    mangiua.Text = data1.ToString() + " ^ " + float.Parse(mangduoi.Text) + " =";
                    mangduoi.Text = data2.ToString();
                    pheptinh = "";
                    break;
                default:
                    // khong khop voi truong hop nao thi thoat 
                    break;
            }
            isNegative = false;
        }
        //button xoá lịch sử
        private void button21_Click(object sender, EventArgs e)
        {
            history.Items.Clear();
        }
        //button chuyen cong tru
        private void btncongtru_Click(object sender, EventArgs e)
        {

        }

        private void btncham_Click(object sender, EventArgs e)
        {          
                   
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //button number 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (isNegative && mangduoi.Text.Length == 7)
            {
                mangduoi.Text = "-7";
            }
            else
            {
                mangduoi.Text = mangduoi.Text + "7";
            }
        }
    }
}
