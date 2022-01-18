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
    public partial class Login : Form
    {
        Dadosusu user;
        public Login()
        {
            InitializeComponent();
            user = new Dadosusu();
        }

        
        private void btlogin_Click(object sender, EventArgs e)
        {
            //percorre o arquivo de usuario para escrever o arquivo de acesso
            using (StreamReader a = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = a.ReadLine()) != null)
                {
                    dados = linha.Split('#');
                    if (!usuario.Text.Equals("") || !senha.Text.Equals(""))
                    {
                        if (usuario.Text.Equals(dados[0]) && senha.Text.Equals(dados[1]))
                        {
                            //armazena os dados do usuario e entregar para o arquivo de acesso
                            string nome = dados[0];
                            string senha = dados[1];
                            string nivel = dados[2];
                            user.acesso(nome, senha, nivel);
                            string data = DateTime.Now.ToString();
                            string s = "Online";
                            user.entrada(nome, data, s);

                            //chama a tela principal
                            Form b = new Principal();
                            b.Show();

                            this.Close();
                            break;
                        }
                    }
                }
            }

            //zera os textbox
            usuario.Text = "";
            senha.Text = "";
        }                
          
        private void label1_Click(object sender, EventArgs e)
        {
            //fecha o programa inteiro
            Application.OpenForms[Application.OpenForms.Count - 2].Close();
        }
    }
  }
    

