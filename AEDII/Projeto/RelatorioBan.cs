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
    public partial class RelatorioBan : Form
    {
        public RelatorioBan()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    cmbrelatorio.Items.Add(d[0]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela do banco de terrorista
            this.Close();
        }

        private void cmbrelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ler o arquivo de relatorio de acordo com o nome selecionado no combobox
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');

                    // verifica a missao selecionada
                    if (cmbrelatorio.SelectedItem.Equals(d[0]))

                    {
                        // preenche as informaçoes
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
                        label6.Text = d[12];

                    }
                }
            }
        }
    }
}
