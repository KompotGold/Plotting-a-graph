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
    public partial class FormGraphics : Form
    {
        private Point mouseDown = Point.Empty;

        private bool isLeftButtonPressed = false;

        double NatMaxX, NatMinX, NatMaxY, NatMinY;
        
        public FormGraphics()
        {
            InitializeComponent();
            chart1.MouseWheel += new MouseEventHandler(chart1_MouseWheel);
            chart1.GetToolTipText += chart_GetToolTipText;
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) 
            {
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum * 0.9;
                chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum * 0.9;
                chart1.ChartAreas[0].AxisY.Maximum = chart1.ChartAreas[0].AxisY.Maximum * 0.9;
                chart1.ChartAreas[0].AxisY.Minimum = chart1.ChartAreas[0].AxisY.Minimum * 0.9;
                chart1.Invalidate();
            }
            if (e.Delta < 0)
            {
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum * 1.1;
                chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum * 1.1;
                chart1.ChartAreas[0].AxisY.Maximum = chart1.ChartAreas[0].AxisY.Maximum * 1.1;
                chart1.ChartAreas[0].AxisY.Minimum = chart1.ChartAreas[0].AxisY.Minimum * 1.1;
                chart1.Invalidate();
            }
        }

        public void ColorGraph()
        {
            if (Global.Flag1)
            {
                chart1.Palette = ChartColorPalette.BrightPastel;
            }
            else if (Global.Flag2)
            {
                chart1.Palette = ChartColorPalette.Bright;
            }
            else if (Global.Flag3)
            {
                chart1.Palette = ChartColorPalette.Grayscale;
            }
            else if (Global.Flag4)
            {
                chart1.Palette = ChartColorPalette.Excel;
            }
            else if (Global.Flag5)
            {
                chart1.Palette = ChartColorPalette.Light;
            }
            else if (Global.Flag6)
            {
                chart1.Palette = ChartColorPalette.Pastel;
            }
            else if (Global.Flag7)
            {
                chart1.Palette = ChartColorPalette.EarthTones;
            }
            else if (Global.Flag8)
            {
                chart1.Palette = ChartColorPalette.SemiTransparent;
            }
            else if (Global.Flag9)
            {
                chart1.Palette = ChartColorPalette.Berry;
            }
            else if (Global.Flag10)
            {
                chart1.Palette = ChartColorPalette.Chocolate;
            }
            else if (Global.Flag11)
            {
                chart1.Palette = ChartColorPalette.Fire;
            }
            else if (Global.Flag12)
            {
                chart1.Palette = ChartColorPalette.SeaGreen;
            }

        }

        public void setArrays(double[] X,double[,] Y , List<string> str)
        {
            int i = 0;
            foreach(string item in str)
            {
                if (chart1.Series.FindByName(item) == null)
                {
                    chart1.Series.Add(item).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[item].BorderWidth = Global.BorderWhidth;
                    chart1.Series[item].IsXValueIndexed = true;
                    chart1.Series[item].ToolTip = "X = #VALX, Y = #VALY";
                    for (int j = 0; j < X.Length; j++)
                    {
                      chart1.Series[item].Points.AddXY(X[j], Y[i,j]);
                    }
                }

                i++;
            }
        }

        private void chart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Если текст в подсказке уже есть, то ничего не меняем.
            if (!String.IsNullOrWhiteSpace(e.Text))
                return;

            Console.WriteLine(e.HitTestResult.ChartElementType);

            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                case ChartElementType.DataPointLabel:
                case ChartElementType.Gridlines:
                case ChartElementType.Axis:
                case ChartElementType.TickMarks:
                case ChartElementType.PlottingArea:
                    // Первый ChartArea
                    var area = chart1.ChartAreas[0];

                    // Его относительные координаты (в процентах от размеров Chart)
                    var areaPosition = area.Position;

                    // Переводим в абсолютные
                    var areaRect = new RectangleF(areaPosition.X * chart1.Width / 100, areaPosition.Y * chart1.Height / 100,
                        areaPosition.Width * chart1.Width / 100, areaPosition.Height * chart1.Height / 100);

                    // Область построения (в процентах от размеров area)
                    var innerPlot = area.InnerPlotPosition;

                    double x = area.AxisX.Minimum +
                                (area.AxisX.Maximum - area.AxisX.Minimum) * (e.X - areaRect.Left - innerPlot.X * areaRect.Width / 100) /
                                (innerPlot.Width * areaRect.Width / 100);
                    double y = area.AxisY.Maximum -
                                (area.AxisY.Maximum - area.AxisY.Minimum) * (e.Y - areaRect.Top - innerPlot.Y * areaRect.Height / 100) /
                                (innerPlot.Height * areaRect.Height / 100);

                    Console.WriteLine("{0:F2} {1:F2}", x, y);
                    e.Text = String.Format("{0:F2} {1:F2}", x, y);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PoUmolch2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum*0.9;
            chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum * 0.9;
            chart1.ChartAreas[0].AxisY.Maximum = chart1.ChartAreas[0].AxisY.Maximum*0.9;
            chart1.ChartAreas[0].AxisY.Minimum = chart1.ChartAreas[0].AxisY.Minimum * 0.9;
            chart1.Invalidate();
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {
           
          

            NatMaxX = chart1.ChartAreas[0].AxisX.Maximum;
            NatMinX = chart1.ChartAreas[0].AxisX.Minimum;

            NatMaxY = chart1.ChartAreas[0].AxisY.Maximum;
            NatMinY = chart1.ChartAreas[0].AxisY.Minimum;
        }





        private void button2_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum * 1.1;
            chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum * 1.1;
            chart1.ChartAreas[0].AxisY.Maximum = chart1.ChartAreas[0].AxisY.Maximum * 1.1;
            chart1.ChartAreas[0].AxisY.Minimum = chart1.ChartAreas[0].AxisY.Minimum * 1.1;
            chart1.Invalidate();
        }

        private void PoUmolch2()
        {
            chart1.ChartAreas[0].AxisX.Maximum= NatMaxX;
            chart1.ChartAreas[0].AxisX.Minimum = NatMinX;
            chart1.ChartAreas[0].AxisY.Maximum=NatMaxY;
            chart1.ChartAreas[0].AxisY.Minimum= NatMinY;
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            chart1.Focus();
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = NatMaxX;
            chart1.ChartAreas[0].AxisX.Minimum = NatMinX;
            chart1.ChartAreas[0].AxisY.Maximum = NatMaxY;
            chart1.ChartAreas[0].AxisY.Minimum = NatMinY;
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonPressed = false;
                mouseDown = Point.Empty;

            }
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonPressed = true;
                mouseDown = e.Location;
            }
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftButtonPressed)
            {
                var result = chart1.HitTest(e.X, e.Y);

                if (result.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.PlottingArea)
                {
                    this.chart1.Cursor = System.Windows.Forms.Cursors.SizeAll;
                    var oldXValueX = result.ChartArea.AxisX.PixelPositionToValue(mouseDown.X);
                    var newXValueX = result.ChartArea.AxisX.PixelPositionToValue(e.X);
                    var oldXValueY = result.ChartArea.AxisY.PixelPositionToValue(mouseDown.Y);
                    var newXValueY = result.ChartArea.AxisY.PixelPositionToValue(e.Y);

                    chart1.ChartAreas[0].AxisX.Maximum += oldXValueX / 5 - newXValueX / 5;
                    chart1.ChartAreas[0].AxisX.Minimum += oldXValueX / 5 - newXValueX / 5;
                    chart1.ChartAreas[0].AxisY.Maximum += oldXValueY / 8 - newXValueY / 8;
                    chart1.ChartAreas[0].AxisY.Minimum += oldXValueY / 8 - newXValueY / 8;

                    chart1.Invalidate();


                    mouseDown.X = e.X;
                    chart1.Invalidate();
                }
            }
        }

    }
}
