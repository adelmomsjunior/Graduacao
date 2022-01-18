using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Fenotran
{
    public partial class R2DuasParedes : Form
    {
        public R2DuasParedes()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void btnova_Click(object sender, EventArgs e)
        {
            Form a = new DuasParedes();
            a.Show();
            this.Close();
        }

        private void R2DuasParedes_Load(object sender, EventArgs e)
        {
            Image a = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhaed.gif");
            Image b = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Duased.png");
            Image c = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhade.gif");
            Image j = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Duasde.png");

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    lq.Text = d[0] + " " + d[16];
                    lrtk1.Text = d[1] + " " + d[17];
                    lrtk2.Text = d[2] + " " + d[17];
                    lrth1.Text = d[3] + " " + d[17];
                    lrth2.Text = d[4] + " " + d[17];
                    lk1.Text = d[5] + " " + d[18];
                    ll1.Text = d[6] + " " + d[19];
                    lk2.Text = d[7] + " " + d[18];
                    ll2.Text = d[8] + " " + d[19];
                    lh1.Text = d[9] + " " + d[20];
                    lh2.Text = d[10] + " " + d[20];
                    lt1.Text = d[11];
                    lt2.Text = d[12];
                    lt3.Text = d[13];
                    lt4.Text = d[14];
                    lt5.Text = d[15];

                    if (float.Parse(d[11]) > float.Parse(d[15]))
                    {
                        pictureBox5.Image = a;
                        pictureBox7.Image = b;
                    }

                    else
                    {
                        pictureBox5.Image = c;
                        pictureBox7.Image = j;
                    }
                }
            }

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo1.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    lt11.Text = d[0];
                    lt12.Text = d[1];
                    lt13.Text = d[2];
                    lt14.Text = d[3];
                    lt15.Text = d[4];

                    if (float.Parse(d[0]) > float.Parse(d[4]))
                    {
                        pictureBox6.Image = a;
                        pictureBox8.Image = b;
                    }

                    else
                    {
                        pictureBox6.Image = c;
                        pictureBox8.Image = j;
                    }
                }
            }
        }

        private void S1Diagrama1_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
        }

        private void S1Diagrama2_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }

        private void S2Diagrama1_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void S2Diagrama2_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
        }
    }
}
