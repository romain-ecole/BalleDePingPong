using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leProjetBalle2PingPong.dossierFenBalle
{
    public partial class codeFenBalle : Form
    {

        private static int AvancerH(bool haut, int phaut)
        {
            if (haut == true)
            {
                return phaut++;
            }
            else
            {
                return phaut--;
            }
        }

        public codeFenBalle()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {

            var random = new Random();
            int i = 0;
            int pgauche = Convert.ToUInt16(random.Next(489));
            int phaut = 488;
            bool haut = false;
            bool droite = Convert.ToBoolean(random.Next(2) == 1); // 0 = false, 1 = true;
            int limite = 490;
            bBalle.Location = new Point(pgauche, phaut);
            while (i <= 10)
            {
                if (pgauche > 1 && pgauche < limite - 1 && phaut > 1 && phaut < limite - 1)
                {
                    if (haut == true)
                    {
                        phaut--;
                        bBalle.Location = new Point(pgauche, phaut);
                    }
                    else
                    {
                        phaut++;
                        bBalle.Location = new Point(pgauche, phaut);
                    }
                    if (droite == true)
                    {
                        pgauche--;
                        bBalle.Location = new Point(pgauche, phaut);
                        System.Threading.Thread.Sleep(1);
                    }
                    else
                    {
                        pgauche++;
                        bBalle.Location = new Point(pgauche, phaut);
                        System.Threading.Thread.Sleep(1);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        if (haut)
                        {
                            haut = false;
                            phaut++;
                            bBalle.Location = new Point(pgauche, phaut);
                            i++;
                        }
                        else
                        {
                            haut = true;
                            phaut--;
                            bBalle.Location = new Point(pgauche, phaut);
                            i++;
                        }
                    }
                    else
                    {
                        if (droite)
                        {
                            droite = false;
                            pgauche++;
                            bBalle.Location = new Point(pgauche, phaut);
                            i++;
                        }
                        else
                        {
                            droite = true;
                            pgauche--;
                            bBalle.Location = new Point(pgauche, phaut);
                            i++;
                        }
                    }
                }
            }
        }
    }
}