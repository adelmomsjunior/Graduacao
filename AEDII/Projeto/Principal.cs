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
    public partial class Principal : Form
    {
        Dadosusu user;

        public Principal()
        {
            InitializeComponent();
            user = new Dadosusu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama a tela de login
            Form a = new Login();
            a.Show();
            string data = DateTime.Now.ToString();
            user.saida(data);
            //fecha a tela principal
            this.Close();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //percorre o arquivo para verificar sua condiçoes de cadastro
            using (StreamReader a = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\acesso.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = a.ReadLine()) != null)
                {                    
                    dados = linha.Split('#');
                    label2.Text = dados[0];
                    if (dados[2] == "Nivel - 2")
                    {                        
                        deletarUsuárioToolStripMenuItem.Visible = false;
                        históricoDeLoginToolStripMenuItem.Visible = false;
                    }
                    if (dados[2] == "Nivel - 3")
                    {
                        editarBancoToolStripMenuItem.Visible = false;
                        usuáriosToolStripMenuItem.Visible = false;
                        missõesToolStripMenuItem.Visible = false;
                    }
                }
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //recebe a data e hora do computador
            label1.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //chama a tela de cadastro
            Form a = new CadUsuario();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void visualizarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chama a tela do banco do terrorista
            Form a = new BancoTerrorista();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela do cadastro do terrorista
            Form a = new CadastrarTerrorista();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void editarTerroristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de editar o terrorista
            Form a = new ModificarTerroristacs();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void deletarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de deletar o usuario
            Form a = new DelUsuario();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void enviarAtaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de ataque
            Form a = new Ataque();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void visualizarRelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de relatorio
            Form a = new RelatorioBan();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void visualizarAreasAtingidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de relatorio
            Form a = new Estatisticas();
            a.Show();

            // fecha a tela principal
            this.Close();
        }

        private void históricoDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama a tela de historico
            Form a = new Historico();
            a.Show();

            // fecha a tela principal
            this.Close();
        }
    }
}
