using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani4ITAMasterClassForDasAbitur
{
    public partial class Mrizka : Form
    {
        TypMrizky typ = TypMrizky.Zadna;
        Pen outline = new Pen(Color.Black, 3);

        int radku, sloupcu;
        int zvolenyX = -1, zvolenyY = -1;

        public Mrizka() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            typ = TypMrizky.PocetCtverecku;
            mrizkaCanvas1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e) {
            typ = TypMrizky.VelikostCtverecku;
            mrizkaCanvas1.Refresh();
        }

        private void mrizkaCanvas1_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;
            if (typ == TypMrizky.PocetCtverecku) {
                VykresliCtvereckyPodlePoctu(g);
            } else if(typ == TypMrizky.VelikostCtverecku) {
                VykresliCtvereckyPodleVelikosti(g);
            } else {
                g.DrawString("Vyber si typ mřížky", SystemFonts.MenuFont, Brushes.Black, new Point(0, 0));
            }
        }

        private void VykresliCtvereckyPodlePoctu(Graphics g) {
            radku = (int)numericUpDown1.Value;
            sloupcu = (int)numericUpDown2.Value;
            if(radku == 0 || sloupcu == 0) {
                MessageBox.Show("Musí být aspoň 1 řádek a 1 sloupec");
                return;
            }

            int sirkaSloupce = mrizkaCanvas1.Width / sloupcu;
            int vyskaRadku = mrizkaCanvas1.Height / radku;

            VykresliMrizku(g, sloupcu, radku, sirkaSloupce, vyskaRadku);
        }

        private void VykresliCtvereckyPodleVelikosti(Graphics g) {
            int sirkaSloupce = (int) numericUpDown3.Value;
            int vyskaRadku = (int) numericUpDown4.Value;

            radku = mrizkaCanvas1.Height / vyskaRadku;
            sloupcu = mrizkaCanvas1.Width / sirkaSloupce;

            VykresliMrizku(g, sloupcu, radku, sirkaSloupce, vyskaRadku);
        }

        private void VykresliMrizku(Graphics g, int sloupcu, int radku, int velS, int velR) {
            bool sachovnice = checkBox1.Checked;
            for (int i = 0; i < radku; i++) {
                for (int j = 0; j < sloupcu; j++) {
                    if (sachovnice) {
                        g.FillRectangle(((j % 2 == 0 && i % 2 == 0) || (j % 2 == 1 && i % 2 == 1)) ? Brushes.White : Brushes.Black, j * velS, i * velR, velS, velR);
                        if(j == zvolenyX && i == zvolenyY) {
                            g.FillRectangle(Brushes.Yellow, j * velS, i * velR, velS, velR);

                        }
                    }
                    g.DrawRectangle(outline, j * velS, i * velR, velS, velR);
                }
            }
        }

        private void mrizkaCanvas1_MouseClick(object sender, MouseEventArgs e) {
            /*MessageBox.Show(
                (e.X / (mrizkaCanvas1.Width / sloupcu)).ToString() + ":" +
                (e.Y / (mrizkaCanvas1.Height / radku)).ToString()
                );
            */
            zvolenyX = e.X / (mrizkaCanvas1.Width / sloupcu);
            zvolenyY = e.Y / (mrizkaCanvas1.Height / radku);
            mrizkaCanvas1.Refresh();
        }
    }

    enum TypMrizky {
        Zadna, PocetCtverecku, VelikostCtverecku
    }
}
