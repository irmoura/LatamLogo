using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatamLogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            graphics = this.CreateGraphics();
            //
            GraphicsPath path01 = new GraphicsPath();//WHITE
            GraphicsPath path02 = new GraphicsPath();//WHITE
            GraphicsPath path03 = new GraphicsPath();//WHITE
            GraphicsPath path04 = new GraphicsPath();//WHITE
            GraphicsPath path05 = new GraphicsPath();//RED
            GraphicsPath path06 = new GraphicsPath();//RED
            GraphicsPath path07 = new GraphicsPath();//RED
            //
            path01.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 143, centralVerticalLine + 455),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine + 360),
                new PointF(centralHorizontalLine - 47,  centralVerticalLine + 325),
                new PointF(centralHorizontalLine - 47,  centralVerticalLine + 420),
            });
            path02.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 143, centralVerticalLine + 303),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine + 208),
                new PointF(centralHorizontalLine + 78,  centralVerticalLine + 135),
                new PointF(centralHorizontalLine + 78,  centralVerticalLine + 225),
            });
            path03.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 143, centralVerticalLine + 150),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine + 55),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 92),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine),
            });
            path04.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 143, centralVerticalLine - 10),
                new PointF(centralHorizontalLine - 273,  centralVerticalLine - 63),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 256),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 161),
            });
            path05.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 273,  centralVerticalLine - 63),
                new PointF(centralHorizontalLine - 273,  centralVerticalLine - 158),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine - 108),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine - 10),
            });
            path06.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 273,  centralVerticalLine - 213),
                new PointF(centralHorizontalLine - 273,  centralVerticalLine - 308),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 92),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine),
            });
            path07.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 143,  centralVerticalLine - 320),
                new PointF(centralHorizontalLine - 143,  centralVerticalLine - 415),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 256),
                new PointF(centralHorizontalLine + 289,  centralVerticalLine - 161),
            });
            //
            graphics.FillPath(Brushes.Red, path05);
            graphics.FillPath(Brushes.Red, path06);
            graphics.FillPath(Brushes.Red, path07);
            graphics.FillPath(Brushes.White, path01);
            graphics.FillPath(Brushes.White, path02);
            graphics.FillPath(Brushes.White, path03);
            graphics.FillPath(Brushes.White, path04);
        }
    }
}
