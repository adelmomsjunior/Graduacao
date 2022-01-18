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

namespace Projeto
{
    public partial class RelatorioUlt : Form
    {
        public RelatorioUlt()
        {
            InitializeComponent();
        }

        private void RelatorioUlt_Load(object sender, EventArgs e)
        {
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\ultimorelatorio.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    
                        groupBox1.Visible = true;
                        label1.Text = d[0];
                        label24.Text = d[1];
                        label15.Text = d[2];
                        label16.Text = d[3];
                        label17.Text = d[4];
                        label18.Text = d[5];
                        label19.Text = d[6];
                        label22.Text = d[7];
                        label21.Text = d[8];
                        label20.Text = d[9];
                        label26.Text = d[10];
                        label23.Text = d[11];
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form a = new Principal();
            a.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form a = new Ataque();
            a.Show();

            this.Close();
        }
                
    }
}
