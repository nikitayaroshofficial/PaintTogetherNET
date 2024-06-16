using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        int X=0, Y=0, dX=1, dY=1, speed=10;

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Press [F1] for [HELP]","PaintTogether",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AboutForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("No help available.\n(so leave me alone)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AboutForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("No help available.\n(so leave me alone)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Graphics pg;
        Brush mbrush;

        private void AboutForm_Load(object sender, EventArgs e)
        {
            /* pg = panel1.CreateGraphics();
             mbrush = Brushes.Green;
             timer1.Enabled = true;
             RectangleF dRect = new RectangleF((panel1.Width/2)-50, (panel1.Height/2)-25, 100, 50);
             pg.DrawString("PAINT TOGETHER", SystemFonts.DefaultFont, mbrush, dRect);*/
            label1.Text =
                "####    #   ##### #   # #####       #####  ###   #### ##### ##### #   # ##### #### " + "\n" +
                "#   #  # #    #   ##  #   #           #   #   # #     #       #   #   # #     #   #" + "\n" +
                "####  #####   #   # # #   #           #   #   # #  ## #####   #   ##### ##### #### " + "\n" +
                "#     #   #   #   #  ##   #           #   #   # #   # #       #   #   # #     #   #" + "\n" +
                "#     #   # ##### #   #   #           #    ###   ###  #####   #   #   # ##### #   #";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*RectangleF dRect = new RectangleF(X, Y, 50, 25);
            pg.DrawString("#### ####", SystemFonts.DefaultFont, mbrush, dRect);
            if (X+50 > panel1.Width|| X < 0)
            {
                dX = 0 - dX;
            }
            if (Y+25 > panel1.Height || Y<0)
            {
                dY = 0 - dY;
            }
            X += dX * speed;
            Y += dY * speed;*/
        }
    }
}
