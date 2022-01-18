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
    public partial class R2UmaParede : Form
    {
        public R2UmaParede()
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
            Form a = new UmaParede();
            a.Show();
            this.Close();
        }

        private void R2UmaParede_Load(object sender, EventArgs e)
        {
            Image a = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhaed.gif");
            Image b = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Umaed.png");
            Image c = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhade.gif");
            Image j = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Umade.png");

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    label1.Text = d[0] + " " + d[12];
                    label2.Text = d[1] + " " + d[13];
                    label3.Text = d[2] + " " + d[13];
                    label4.Text = d[3] + " " + d[13];
                    label5.Text = d[4] + " " + d[14];
                    label6.Text = d[5] + " " + d[15];
                    label7.Text = d[6] + " " + d[16];
                    label8.Text = d[7] + " " + d[16];
                    label9.Text = d[8]; 
                    label10.Text = d[9]; 
                    label11.Text = d[10]; 
                    label12.Text = d[11];

                    if (float.Parse(d[8]) > float.Parse(d[11]))
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
                    label13.Text = d[0];
                    label14.Text = d[1];
                    label15.Text = d[2];
                    label16.Text = d[3];

                    if (float.Parse(d[0]) > float.Parse(d[3]))
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
