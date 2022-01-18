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
    public partial class CadUsuario : Form
    {
        //variavel para acessar a classe de dados usuario
        Dadosusu user;

        public CadUsuario()
        {
            InitializeComponent();
            //variavel para acessar a classe de dados usuario
            user = new Dadosusu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario.Text = "";
            senha1.Text = "";
            senha2.Text = "";

            // chama tela principal
            Form a = new Principal();
            a.Show();

            // fecha a tela e zera os textbox
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //verifica se as senha sao iguais
            if (senha1.Text != senha2.Text)
            {
                MessageBox.Show("Senhas não são iguais");
                senha1.Text = "";
                senha2.Text = "";
            }

            //verifica se o nivel foi escolhido
            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Escolha seu nivel hierárquico");
            }

            // verifica se ja existe o usuario digitado
            using (StreamReader a = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = a.ReadLine()) != null)
                {
                    dados = linha.Split('#');
                    if (usuario.Text == dados[0])
                    {
                        MessageBox.Show("Nome de usuário ja existente");
                        usuario.Text = "";
                    }
                }
            }

            //verifica os campos digitados
            if (usuario.Text.Equals(""))
            {
                MessageBox.Show("Digite um usuário valido");
            }

            if (senha1.Text.Equals(""))
            {
                MessageBox.Show("Digite uma senha valida");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //salvar o usuario
            if (radioButton1.Checked)
            {
                string nivel = "Nivel - 1";
                user.salvarusuario(usuario.Text, senha1.Text, nivel);
                MessageBox.Show("Usuário Cadastrado");

                //chama  a tela principal
                Form a = new Principal(); a.Show();

                //fecha a tela de cadastro de usuario
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                string nivel = "Nivel - 2";
                user.salvarusuario(usuario.Text, senha1.Text, nivel);
                MessageBox.Show("Usuário Cadastrado");

                //chama  a tela principal
                Form a = new Principal(); a.Show();

                //fecha a tela de cadastro de usuario
                this.Close();

            }
            else if (radioButton3.Checked)
            {
                string nivel = "Nivel - 3";
                user.salvarusuario(usuario.Text, senha1.Text, nivel);
                MessageBox.Show("Usuário Cadastrado");

                //chama  a tela principal
                Form a = new Principal(); a.Show();

                //fecha a tela de cadastro de usuario
                this.Close();

            }
            else if (radioButton4.Checked)
            {
                string nivel = "Nivel - 3";
                user.salvarusuario(usuario.Text, senha1.Text, nivel);
                MessageBox.Show("Usuário Cadastrado");

                //chama  a tela principal
                Form a = new Principal(); a.Show();

                //fecha a tela de cadastro de usuario
                this.Close();

            }

        }

        private void usuario_MouseMove(object sender, MouseEventArgs e)
        {
            //percorre o arquivo para verificar sua condiçoes de cadastro
            using (StreamReader a = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\acesso.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = a.ReadLine()) != null)
                {
                    dados = linha.Split('#');
                    if (dados[2] == "Nivel - 1")
                    {
                        radioButton1.Visible = true;
                        radioButton2.Visible = true;
                        radioButton3.Visible = true;
                    }
                    if (dados[2] == "Nivel - 2")
                    {
                        radioButton4.Visible = true;

                    }
                }
            }
        }
                
    }
}
