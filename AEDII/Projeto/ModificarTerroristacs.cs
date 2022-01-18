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
    public partial class ModificarTerroristacs : Form
    {
        DadosTerro ch;
        public ModificarTerroristacs()
        {
            InitializeComponent();
            ch = new DadosTerro();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    cmbmodifterrorista.Items.Add(d[0]);
                }
            }
        }

        private void btmodterroretorna_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela atual
            this.Close();
        }

        private void btmodconcluir_Click(object sender, EventArgs e)
        {
            
            if (cmbstatus.Text.Equals("") || txtmodobs.Text.Equals("") || txtmodidade.Text.Equals(""))
            {
                MessageBox.Show("Preencha os campos obrigatórios");
            }
            else
            {
                
                ch.mod(cmbmodifterrorista.SelectedItem.ToString(), cmbstatus.Text,txtmodidade.Text,txtmodaltura.Text,txtmodpeso.Text,txtmodnatural.Text,txtmodmarcas.Text,txtmodobs.Text,txtmodfoto.Text);
                cmbmodifterrorista.Text = "";
                cmbstatus.Text = "";
                txtmodidade.Text = "";
                txtmodaltura.Text = "";
                txtmodpeso.Text = "";
                txtmodnatural.Text = "";
                txtmodmarcas.Text = "";
                txtmodobs.Text = "";
                picmodterror.Visible = false;
                txtmodfoto.Text = "";

            }

        }

        private void cmbmodifterrorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');

                    if (cmbmodifterrorista.SelectedItem.Equals(d[0]))
                    {
                        cmbstatus.Text = d[1];
                        txtmodidade.Text = d[2];
                        txtmodaltura.Text = d[3];
                        txtmodpeso.Text = d[4];
                        txtmodnatural.Text = d[5];
                        txtmodmarcas.Text = d[6];
                        txtmodobs.Text = d[7];
                        picmodterror.ImageLocation = d[8];
                        picmodterror.Visible = true;
                        txtmodfoto.Text = d[8];

                    }
                }
            }
        }


    }
}
