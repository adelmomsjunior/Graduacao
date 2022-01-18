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
    public partial class CadastrarTerrorista : Form
    {
        DadosTerro ch;
        public CadastrarTerrorista()
        {
            InitializeComponent();
            ch = new DadosTerro();
            txtcadtstatus.Text = "VIVO";
        }

   
        private void btcadtcadastra_Click_1(object sender, EventArgs e)
        {
            

            if (txtcadtaltura.Text == "")
            {
                txtcadtaltura.Text = "Desconhecido";
            }
            if (txtcadtpeso.Text == "")
            {
                txtcadtpeso.Text = "Desconhecido";
            }
            if (txtcadtnatural.Text == "")
            {
                txtcadtnatural.Text = "Desconhecido";
            }
            if (txtcadtmarcas.Text == "")
            {
                txtcadtmarcas.Text = "Desconhecido";
            }
            if (txtcadtfoto.Text == "")
            {
                txtcadtfoto.Text = Environment.CurrentDirectory + "\\Imagens\\user.png";
            }

            ch.salvarterrorista(txtcadtnome.Text, txtcadtstatus.Text, txtcadtidade.Text, txtcadtaltura.Text, txtcadtpeso.Text, txtcadtnatural.Text, txtcadtmarcas.Text, txtcadtobs.Text, txtcadtfoto.Text);
            txtcadtnome.Text = "";
            txtcadtidade.Text = "";
            txtcadtaltura.Text = "";
            txtcadtpeso.Text = "";
            txtcadtnatural.Text = "";
            txtcadtobs.Text = "";
            txtcadtmarcas.Text = "";
            txtcadtfoto.Text = "";
            MessageBox.Show("Terrorista Cadastrado");

        }

        private void btcadtretorna_Click_1(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela atual
            this.Close();
        }

        private void btcadtcadastra_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtcadtnome.Text == ""  || txtcadtidade.Text == ""|| txtcadtobs.Text=="")
            {
                MessageBox.Show("Preencha os campos obrigatórios");
            }

            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    if (txtcadtnome.Text.Equals(d[0]))
                    {
                        MessageBox.Show("Nome de terrorista existente!");
                        txtcadtnome.Text = "";
                    }
                }
            }
        }

        private void CadastrarTerrorista_Load(object sender, EventArgs e)
        {

        }

     
    }
}
