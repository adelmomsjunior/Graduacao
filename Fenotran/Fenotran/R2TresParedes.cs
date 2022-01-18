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
    public partial class R2TresParedes : Form
    {
        public R2TresParedes()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void BtNovaConv_Click(object sender, EventArgs e)
        {
            Form a = new TresParedes();
            a.Show();
            this.Close();
        }

        private void R2TresParedes_Load(object sender, EventArgs e)
        {
            Image a = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhaed.gif");
            Image b = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Tresed.png");
            Image c = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhade.gif");
            Image j = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Tresde.png");

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    label1.Text = d[0] + " " + d[20];
                    label2.Text = d[1] + " " + d[21];
                    label3.Text = d[2] + " " + d[21];
                    label4.Text = d[3] + " " + d[21];
                    label5.Text = d[4] + " " + d[21];
                    label6.Text = d[5] + " " + d[21];
                    label7.Text = d[6] + " " + d[22];
                    label8.Text = d[7] + " " + d[23];
                    label9.Text = d[8] + " " + d[22];
                    label10.Text = d[9] + " " + d[23];
                    label11.Text = d[10] + " " + d[22];
                    label12.Text = d[11] + " " + d[23];
                    label13.Text = d[12] + " " + d[24];
                    label14.Text = d[13] + " " + d[24];
                    label15.Text = d[14];
                    label16.Text = d[15];
                    label17.Text = d[16];
                    label18.Text = d[17];
                    label19.Text = d[18];
                    label20.Text = d[19];

                    if (float.Parse(d[14]) > float.Parse(d[19]))
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
                    label21.Text = d[0];
                    label22.Text = d[1];
                    label23.Text = d[2];
                    label24.Text = d[3];
                    label25.Text = d[4];
                    label26.Text = d[5];

                    if (float.Parse(d[0]) > float.Parse(d[5]))
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
