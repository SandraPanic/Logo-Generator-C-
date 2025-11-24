using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOYOTA
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
               Pen aOlovka = new Pen(Color.Gray, 5);
               g.DrawEllipse(aOlovka, new Rectangle(50, 50, 300, 200));
               g.DrawEllipse(aOlovka, new Rectangle(105, 50, 180, 70));
               g.DrawEllipse(aOlovka, new Rectangle(155, 50, 80, 200));

               String ds = "Toyota";
               Font dF = new Font("Arial", 20);
               SolidBrush sB = new SolidBrush(Color.Red);
               PointF dP = new PointF(100.0F, 250.0F);
               e.Graphics.DrawString(ds, dF, sB, dP);


          }
     }
}
