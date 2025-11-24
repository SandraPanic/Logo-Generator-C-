using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastercard
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

               SolidBrush solidBrush1 = new SolidBrush(Color.Red);
               SolidBrush solidBrush2 = new SolidBrush(Color.Yellow);

               g.FillEllipse(solidBrush1, new Rectangle(100, 100, 300, 300));
               g.FillEllipse(solidBrush2, new Rectangle(300, 100, 300, 300));

               String drawString = "Mastercard";
               Font drawFont = new Font("Arial", 60, FontStyle.Bold);
               Point drawPoint = new Point(120, 420);
               SolidBrush solidBrush3 = new SolidBrush(Color.Red);
               e.Graphics.DrawString(drawString, drawFont, solidBrush3, drawPoint);
          }
     }
}
