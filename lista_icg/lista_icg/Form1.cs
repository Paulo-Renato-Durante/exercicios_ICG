using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_icg
{
    public partial class Form1 : Form
    {
        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen caneta(Color cor, int espessura)
        {
            return new Pen(cor, espessura);
        }
        public void retaBreseham(int x0, int y0, int x1, int y1, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta,x0, y0, x1, y1);
        }
        public void desenhaFormas(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            int i1 = 0;
            int i2 = 2;
            for (int i = 0; i< pontos.Length/2; i++)
            {
                retaBreseham(pontos[i1], pontos[i1 + 1], pontos[i2], pontos[i2+1], caneta, e);
                i1 += 2;
                i2 += 2;
                if (i2 == pontos.Length)
                {
                    i2 = 0;
                }


            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int[] pontos = new int[] {900, 540, 960, 460, 1020, 540, 1110, 540, 1035, 600, 1060, 680, 960, 630, 860, 680, 885, 600, 810, 540 };
            desenhaFormas(e, pontos, caneta(cor(255,0,0),2));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }
}
