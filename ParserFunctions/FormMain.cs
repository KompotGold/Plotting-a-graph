using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ParserFunctions
{
    public partial class FormMain : Form
    {   
        private double a;
        private double b;
        private int N;
        

      
        private List<string> functions;

        private Setting seting;
        private About about;
        private Spravka Spravka;
        private FormGraphics formGraphics;


        private Parser parser;

        private double[] X;
        private double[,] Y;
        

        public FormMain()
        {
            InitializeComponent();
   
            this.MaximizeBox = false;
        
            functions = new List<string>();   
        }



        private void button3_Click(object sender, EventArgs e)
        {
            formGraphics = new FormGraphics();
            if (checkInput() && functions.Count != 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                N = Convert.ToInt32(textBox3.Text);

                parser = new Parser(functions,a,b,N);

                X = parser.getArrayX();
                Y = parser.getArraysY();
                
                formGraphics.ColorGraph();
                formGraphics.setArrays(X, Y, functions);
                formGraphics.Show();
            }
            else
            {
                MessageBox.Show("Добавьте функцию", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool checkInput()
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Введите начало отрезка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Введите конец отрезка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Введите количество точек", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = comboBox1.Text;


            if (comboBox1.Items.IndexOf(str) == -1)
            {
                if (Parser.checkSyntax(str))
                {
                    comboBox1.Items.Add(str);
                    functions.Add(str);
                    MessageBox.Show("Успешно добавленно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Ошибка синтаксиса,\nпроверьте ввод.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Такой элемент существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            if (str.Length != 0)
            {
                comboBox1.Text = "";

                comboBox1.Items.Remove(str);
                functions.Remove(str);
                MessageBox.Show("Успешно удаленно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Выберите функцию", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //comboBox1.Text = "cos(x)";
            //textBox1.Text = "-10";
            //textBox2.Text = "10";
            //textBox3.Text = "100";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Spravka = new Spravka();
            Spravka.Show();
        }

        private void версияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.Show();
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seting = new Setting();
            seting.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= '0' && c <= '9' || c == ',' || c=='-' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= '0' && c <= '9' || c == ',' || c == '-' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= '0' && c <= '9' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
