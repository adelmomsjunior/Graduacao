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
    public partial class R1DuasParedes : Form
    {
        public R1DuasParedes()
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

        private void R1DuasParedes_Load(object sender, EventArgs e)
        {
            Image a = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhaed.gif");
            Image b = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Duased.png");
            Image c = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Linhade.gif");
            Image j = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Duasde.png");

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                string line;
                string[] d;
                while((line=op.ReadLine())!=null)
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
                        pictureBox3.Image = a;
                        pictureBox4.Image = b;
                    }

                    else
                    {
                        pictureBox3.Image = c;
                        pictureBox4.Image = j;
                    }
                }
            }
        }
        
        private void Diagrama1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void Diagram2_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }
    }
}
