using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          protected override void OnPaint(PaintEventArgs e)
          {
               Graphics g = e.Graphics;

               SolidBrush OrangeRedBrush = new SolidBrush(Color.OrangeRed);
               SolidBrush YellowGreenBrush = new SolidBrush(Color.YellowGreen);
               SolidBrush RoyalBlueBrush = new SolidBrush(Color.RoyalBlue);
               SolidBrush GoldenrodBrush = new SolidBrush(Color.Goldenrod);

               g.FillRectangle(OrangeRedBrush, 100, 100, 80, 80);
               g.FillRectangle(YellowGreenBrush, 187, 100, 80, 80);
               g.FillRectangle(RoyalBlueBrush, 100, 187, 80, 80);
               g.FillRectangle(GoldenrodBrush, 187, 187, 80, 80);

               String drawString = "Microsoft";
               Font drawFont = new Font("Arial", 80,FontStyle.Bold);
               SolidBrush drawBrush = new SolidBrush(Color.Gray);
               Point drawPoint = new Point(290, 120);
               e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
          }
     }
}
