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
    public partial class R2Cilindrico : Form
    {
        public R2Cilindrico()
        {
            InitializeComponent();
        }

        private void R2Cilindrico_Load(object sender, EventArgs e)
        {
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    label1.Text = d[0] + " " + d[14];
                    label2.Text = d[1] + " " + d[15];
                    label3.Text = d[2] + " " + d[15];
                    label4.Text = d[3] + " " + d[15];
                    label5.Text = d[4] + " " + d[16];
                    label6.Text = d[5] + " " + d[16];
                    label7.Text = d[6] + " " + d[17];
                    label8.Text = d[7] + " " + d[16];
                    label9.Text = d[8] + " " + d[18];
                    label10.Text = d[9] + " " + d[18];
                    label11.Text = d[10];
                    label12.Text = d[11];
                    label13.Text = d[12];
                    label14.Text = d[13];
                }
            }

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancodeDados\\arquivo1.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    label15.Text = d[0];
                    label16.Text = d[1];
                    label17.Text = d[2];
                    label18.Text = d[3];
                }
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void BtNovaConv_Click(object sender, EventArgs e)
        {
            Form a = new Cilindrico();
            a.Show();
            this.Close();
        }
    }
}
