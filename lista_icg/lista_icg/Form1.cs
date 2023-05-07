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
        public void retaBreseham(int x0, int y0, int x1, int y1, Color cor, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta(cor,1),x0, y0, x1, y1);
        }
        public void pintap(int x, int y , Color cor, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta(cor, 1), x, y, x + 1, y);
        }
        public void desenhaQuadrilatero(PaintEventArgs e,int altura,int largura, Color cor)
        {
            int x= 400;
            int y = 400;
            retaBreseham(x,y,largura+x,y,cor,e);
            retaBreseham(x,y,x,altura+y, cor, e);
            retaBreseham(largura + x,y,x+ largura, altura +y, cor, e);
            retaBreseham(x, altura + y, x + largura, y + altura,cor,e);
            
        }
        public void desenharCirculo(int xc, int yc, int raio, Color cor, PaintEventArgs e)
        {
            int x;
            int y;
            double angulo;

            for (int i = 0; i < 360; i++)
            {
                angulo = i * Math.PI / 180;
                x = (int)(xc + raio * Math.Cos(angulo));
                y = (int)(yc + raio * Math.Sin(angulo));
                pintap(x, y, cor, e);

            }
        }
        public void desenharElipse(int xc, int yc, int raiox,int raioy, Color cor, PaintEventArgs e)
        {
            int x;
            int y;
            double angulo;
            for (int i = 0; i < 360; i++)
            {
                angulo = i * Math.PI / 180;
                x = (int)(xc + raiox * Math.Cos(angulo));
                y = (int)(yc + raioy * Math.Sin(angulo));
                pintap(x, y, cor, e);
            }
        }

        public void desenhaFormas(PaintEventArgs e, int[] pontos, Color cor)
        {
            for (int i = 0; i < pontos.Length - 2; i += 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], cor, e);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length - 2], pontos[pontos.Length - 1], cor, e);
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
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }
}
