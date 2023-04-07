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
            for (int i = 0; i < pontos.Length-2 ; i += 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length - 2], pontos[pontos.Length - 1], caneta, e);
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
            int[] pontos = new int[] { 760, 73, 745, 233, 755, 389, 821, 398, 800, 370, 790, 280, 815
                , 150, 860, 45, 830, 240, 845, 374, 922, 377, 890, 340, 880, 290, 890, 234, 930, 200,
                966, 200, 990, 240, 999, 300, 980, 345, 960, 375, 1018, 384, 1041, 353, 1044, 245, 1036,
                144, 1023, 44, 1072, 152, 1087, 272, 1082, 360, 1060, 392, 1124, 393, 1144, 305, 1136,
                185, 1124, 74, 1165, 170, 1180, 270, 1183, 356, 1170, 429, 1100, 438, 1010, 427, 1100,
                465, 1200, 519, 1195, 625, 1150, 757, 1090, 860, 1118, 759, 1140, 660, 1160, 558, 1100,
                516, 1100, 600, 1077, 700, 1024, 822, 1051, 686, 1058, 545, 1021, 487, 1020, 600, 1000,
                697, 960, 770, 940, 785, 914, 776, 870, 707, 855, 630, 858, 485, 800, 515, 812, 583, 825,
                688, 850, 830, 780, 662, 767, 566, 780, 512, 715, 557, 737, 710, 774, 860, 700, 690, 677,
                615, 675, 510, 760, 466, 866, 425, 713, 428, 700, 311, 714, 196 };
            desenhaFormas(e, pontos, caneta(cor(255,0,0),2));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }
}
