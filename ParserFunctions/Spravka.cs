using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserFunctions
{
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Spravka_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text=="Сложение")
            {
                label1.Text = " 2+1 \n 3+2453+(23+90)";
            }
            else if (treeView1.SelectedNode.Text == "Вычитание")
            {
                label1.Text = " 2-1 \n 3-2453-(23-90)";
            }
            else if (treeView1.SelectedNode.Text == "Произведение")
            {
                label1.Text = " 2*3 \n 3*(5*6)";
            }
            else if (treeView1.SelectedNode.Text == "Деление")
            {
                label1.Text = " 90/5 \n (46/5)/234";
            }
            else if (treeView1.SelectedNode.Text == "Вычитание")
            {
                label1.Text = " 2-1 \n 3-2453-(23-90)";
            }
            else if (treeView1.SelectedNode.Text == "cos")
            {
                label1.Text = " cos(x) \n cos(x*2)";
            }
            else if (treeView1.SelectedNode.Text == "sin")
            {
                label1.Text = " sin(x) \n sin(x-10)";
            }
            else if (treeView1.SelectedNode.Text == "tn")
            {
                label1.Text = " tg(x) \n tg(x-10)";
            }
            else if (treeView1.SelectedNode.Text == "ctn")
            {
                label1.Text = " ctg(x) \n ctg(x-10)";
            }
            else if (treeView1.SelectedNode.Text == "Логарифмы с основанием")
            {
                label1.Text = " log(a,b), \n где a-это основание(a>1,a≠0) \n ,а b-это аргумент, число или выражение(b>0) \n Пример использования: log(3,x), log(10,(x*5-4)";
            }
            else if (treeView1.SelectedNode.Text == "Натуральный логарифм")
            {
                label1.Text = " ln(b)-логарифм с основанием Exp,\n где b-это аргумент, число или выражение(b>0) \n Пример использования:ln(x),ln((x-6)*5)";
            }
            else if (treeView1.SelectedNode.Text == "Корень")
            {
                label1.Text = " x^5 или x^((5*3)-4)";
            }
            else if (treeView1.SelectedNode.Text == "Экспонента")
            {
                label1.Text = " exp(x)";
            }
            else if (treeView1.SelectedNode.Text == "Число Pi")
            {
                label1.Text = " Использование в программе: Pi,cos(Pi*4)";
            }
        }
    }
}
