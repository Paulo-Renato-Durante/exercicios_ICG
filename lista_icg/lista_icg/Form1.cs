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
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }
        public void desenhaFormas(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i <= (pontos.Length / 2) + 1; i = i + 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length-2], pontos[pontos.Length-1],caneta,e);
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
            int[] pontos = new int[] { 100, 100, 150, 50, 200, 100, 175, 150, 125, 150 };
            desenhaFormas(e, pontos, caneta(cor(255,0,0),1));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }
}
