using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParserFunctions
{   
    public partial class Setting : Form
    {
        private int min = 1, sred = 3, max = 5;

        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
   
            if (radioButton1.Checked)
            {
                Global.Flag1 = true;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag2 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
            }
            else if(radioButton2.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = true;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag2 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
            }
            else if (radioButton3.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = true;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag2 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
            }
            else if (radioButton4.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = true;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag8= false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton5.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = true;
                Global.Flag6 = false;
                Global.Flag8 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton6.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = true;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton7.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = true;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton8.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = false;
                Global.Flag8 = true;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if(radioButton9.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = true;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton10.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = true;
                Global.Flag11 = false;
                Global.Flag12 = false;
            }
            else if (radioButton11.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = true;
                Global.Flag12 = false;
            }
            else if (radioButton12.Checked)
            {
                Global.Flag1 = false;
                Global.Flag2 = false;
                Global.Flag3 = false;
                Global.Flag4 = false;
                Global.Flag5 = false;
                Global.Flag6 = false;
                Global.Flag7 = false;
                Global.Flag8 = false;
                Global.Flag9 = false;
                Global.Flag10 = false;
                Global.Flag11 = false;
                Global.Flag12 = true;
            }
            if (radioButton13.Checked)
            {
                Global.BorderWhidth = min;
            }
            else if (radioButton14.Checked)
            {
                Global.BorderWhidth = sred;
            }
            else if (radioButton15.Checked)
            {
                Global.BorderWhidth = max;
            }

            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "BrightPastel";
            radioButton2.Text = "Bright";
            radioButton3.Text = "Grayscale";
            radioButton4.Text = "Excel";
            radioButton5.Text = "Light";
            radioButton6.Text = "Pastel";
            radioButton7.Text = "EarthTones";
            radioButton8.Text = "SemiTransparent";
            radioButton9.Text = "Berry";
            radioButton10.Text = "Chocolate";
            radioButton11.Text = "Fire";
            radioButton12.Text = "SeaGreen";
            radioButton13.Text = "Маленький размер графика";
            radioButton14.Text = "Средний размер графика";
            radioButton15.Text = "Большой размер графика";


                if (Global.Flag1)
                {
                    radioButton1.Checked = true;
                }
                else if (Global.Flag2)
                {
                    radioButton2.Checked = true;
                }
                else if (Global.Flag3)
                {
                    radioButton3.Checked = true;
                }
                else if (Global.Flag4)
                {
                    radioButton4.Checked = true;
                }
                else if (Global.Flag5)
                {
                    radioButton5.Checked = true;
                }
                else if (Global.Flag6)
                {
                    radioButton6.Checked = true;
                }
                else if (Global.Flag7)
                {
                    radioButton7.Checked = true;
                }
                else if (Global.Flag8)
                {
                    radioButton8.Checked = true;
                }
                else if (Global.Flag9)
                {
                    radioButton9.Checked = true;
                }
                else if (Global.Flag10)
                {
                    radioButton10.Checked = true;
                }
                else if (Global.Flag11)
                {
                    radioButton11.Checked = true;
                }
                else if (Global.Flag12)
                {
                    radioButton12.Checked = true;
                }
                if (Global.BorderWhidth == min)
                {
                    radioButton13.Checked = true;
                }
                else if (Global.BorderWhidth == sred)
                {
                    radioButton14.Checked = true;
                }
                else if (Global.BorderWhidth == max)
                {
                    radioButton15.Checked = true;
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton13.Checked = true;
            radioButton1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
