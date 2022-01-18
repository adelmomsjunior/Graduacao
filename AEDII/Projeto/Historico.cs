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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void bthisretorna_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela atual
            this.Close();
        }

        private void cmbhistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int cont = 0, i = 0;
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\historico.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    if (cmbhistorico.SelectedItem.Equals(d[0]))
                    {
                        listBox1.Items.Add(d[1]);
                        listBox2.Items.Add(d[2]);
                        cont++;
                    }
                    i++;
                }
               
            }
            if(cont==0)
            {
                MessageBox.Show("O usuário selecionado não fez \n login/logout  no programa \n até o dado momento");
            }
            
            label5.Text = i.ToString();
            label5.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
        }

        private void Historico_Load(object sender, EventArgs e)
        {

            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    cmbhistorico.Items.Add(d[0]);
                }
            }
        }
    }
}
