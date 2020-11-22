using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            ArrayList data = new ArrayList();
            data.Add(new PieChartElement("East", (float)50.75));
            data.Add(new PieChartElement("West", (float)22));
            data.Add(new PieChartElement("North", (float)72.32));
            data.Add(new PieChartElement("South", (float)12));
            data.Add(new PieChartElement("Central", (float)44));

            chart.Image = drawPieChart(data, new Size(chart.Width, chart.Height));
        }

        private Image drawPieChart(ArrayList elements, Size s)
        {
                Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, 
                    Color.Blue, Color.Indigo, Color.Violet, Color.DarkRed, 
                    Color.DarkOrange, Color.DarkSalmon, Color.DarkGreen, 
                    Color.DarkBlue, Color.Lavender, Color.LightBlue, Color.Coral };


            Bitmap bm = new Bitmap(s.Width, s.Height);
            Graphics g = Graphics.FromImage(bm);

            float total = 0;
            foreach(PieChartElement e in elements)
            {
                if(e.value < 0)
                {
                    throw new ArgumentException("All elements must have positive values");
                }
                total += e.value;
            }

            if (total <= 0)
            {
                throw new ArgumentException("Must provide at least one PieChartElement with a positive value");
            }

            Rectangle rect = new Rectangle(1, 1, (s.Width / 2) - 2, s.Height - 2);

            float startAngle = 0;
            int PieColor = 0;
            foreach(PieChartElement e in elements)
            {
                Pen p = new Pen(Color.Black, 1);
                Brush b = new SolidBrush(colors[PieColor++]);

                float sweepAngle = (e.value / total) * 360;
                g.DrawPie(p, rect, startAngle, sweepAngle);
                g.FillPie(b, rect, startAngle, sweepAngle);
                startAngle += sweepAngle;                
            }

            Point IRectCorner = new Point((s.Width / 2) + 2, 1);
            Size IRectSize = new Size(s.Width - (s.Width / 2) - 4, s.Height - 2);
            Rectangle IRect = new Rectangle(IRectCorner, IRectSize);

            Brush lb = new SolidBrush(Color.White);
            Pen lp = new Pen(Color.Black, 1);
            g.FillRectangle(lb, IRect);
            g.DrawRectangle(lp, IRect);

            // int vert = (IRect.Height = 10) / elements.Count;
            // int legendWidth = IRect.Width / 5;
            // int legendHeight = (int)(vert * 0.75);
            // int buffer = (int)(vert - legendHeight) / 2;
            // int textX = IRectCorner.X + legendWidth + buffer * 2;
            // int textWidth = IRect.Width - (IRect.Width / 5) - (buffer * 2);

            int vert = (IRect.Height - 10) / elements.Count;
            int legendWidth = IRect.Width / 5;
            int legendHeight = (int) (vert * 0.75);
            int buffer = (int)(vert - legendHeight) / 2;
            int textX = IRectCorner.X + legendWidth + buffer * 2;
            int textWidth = IRect.Width - (IRect.Width / 5) - (buffer * 2);



            int currectVert = 5;
            int legendColor = 0;
            foreach(PieChartElement e in elements)
            {
                Rectangle thisRect = new Rectangle(IRectCorner.X + buffer, currectVert + buffer,
                    legendWidth, legendHeight);
                Brush b = new LinearGradientBrush(thisRect, colors[legendColor++],
                    Color.White, (float)45);
                g.FillRectangle(b, thisRect);
                g.DrawRectangle(lp, thisRect);

                RectangleF textRect = new Rectangle(textX, currectVert + buffer, 
                    textWidth, legendHeight);
                Font tf = new Font("Arial", 12);
                Brush tb = new SolidBrush(Color.Black);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString($"{e.name} {e.value}", tf, tb, textRect, sf);
                currectVert += vert;
            }

            return bm;
        }
    }
}