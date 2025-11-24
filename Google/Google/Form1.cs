using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google
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



               String drawString = "G";
               Font drawFont = new Font("Arial", 150);
               SolidBrush drawBrush = new SolidBrush(Color.Blue);
               Point drawPoint = new Point(100, 100);
               e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

               String drawString1 = "o";
               Font drawFont1 = new Font("Arial", 150);
               SolidBrush drawBrush1 = new SolidBrush(Color.Red);
               Point drawPoint1 = new Point(245, 100);
               e.Graphics.DrawString(drawString1, drawFont1, drawBrush1, drawPoint1);

               String drawString2 = "o";
               Font drawFont2 = new Font("Arial", 150);
               SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);
               Point drawPoint2 = new Point(350, 100);
               e.Graphics.DrawString(drawString2, drawFont2, drawBrush2, drawPoint2);

               String drawString3 = "g";
               Font drawFont3 = new Font("Arial", 150);
               SolidBrush drawBrush3 = new SolidBrush(Color.Blue);
               Point drawPoint3 = new Point(455, 100);
               e.Graphics.DrawString(drawString3, drawFont3, drawBrush3, drawPoint3);

               String drawString4 = "l";
               Font drawFont4 = new Font("Arial", 150);
               SolidBrush drawBrush4 = new SolidBrush(Color.Green);
               Point drawPoint4 = new Point(550, 100);
               e.Graphics.DrawString(drawString4, drawFont4, drawBrush4, drawPoint4);

               String drawString5 = "e";
               Font drawFont5 = new Font("Arial", 150);
               SolidBrush drawBrush5 = new SolidBrush(Color.Red);
               Point drawPoint5 = new Point(580, 100);
               e.Graphics.DrawString(drawString5, drawFont5, drawBrush5, drawPoint5);

          }

     }
}
