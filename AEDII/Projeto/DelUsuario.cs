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
    public partial class DelUsuario : Form
    {
        Dadosusu usuario;

        string nome;

        public DelUsuario()
        {
            InitializeComponent();
            usuario = new Dadosusu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela de deletar usuario
            this.Close();

            //zera o combobox
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void DelUsuario_Load(object sender, EventArgs e)
        {
            // Ler o arquivo de terrorista e preenche o combobox
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
            {
                string linha;
                string[] d;
                while ((linha = op.ReadLine()) != null)
                {
                    d = linha.Split('#');
                    if (!d[0].Equals(""))
                    {
                        comboBox1.Items.Add(d[0]);
                    }
                    
                }
            }

            //percorre o arquivo de acesso e salva o usuario em uma varivel
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\acesso.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    nome = d[0];
                }
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //verifica se o usuario esta selecionado corretamente
            if (comboBox1.Text != textBox1.Text)
            {
                MessageBox.Show("Selecione corretamente o usuario");

                //zera o combobox
                comboBox1.Text = "";
                textBox1.Text = "";
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //5456465456465
            // Ler o arquivo de terrorista e preenche o combobox
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] d;
                int x = 0;
                while ((linha = op.ReadLine()) != null)
                {
                    d = linha.Split('#');
                    if (d[12].Equals(comboBox1.SelectedItem.ToString()))
                    {        
                        x = 1;
                    }                    
                }
                if (x == 1)
                {
                    MessageBox.Show("Usuario não pode ser Deletado");

                    //chama a tela principal
                    Form a = new Principal();
                    a.Show();
                }
                //senao compara se o usuario esta se auto deletando ou nao

                //se for verdade 
                else if (nome == comboBox1.SelectedItem.ToString())
                {
                    MessageBox.Show("Usuario Deletado");

                    //chama a função para deletar o usuario
                    usuario.delusu(comboBox1.SelectedItem.ToString());
                    usuario.delhis(comboBox1.SelectedItem.ToString());

                    //chama a função para reescrever o arquivo
                    usuario.atualizausu();
                    usuario.atualizahis();

                    //chama a tela de login                        
                    Form b = new Login();
                    b.Show();
                }

                //senao ele esta deletando um outro usuario qualquer
                else
                {
                    MessageBox.Show("Usuario Deletado");

                    //chama a função para deletar o usuario
                    usuario.delusu(comboBox1.SelectedItem.ToString());
                    usuario.delhis(comboBox1.SelectedItem.ToString());

                    //chama a função para reescrever o arquivo
                    usuario.atualizausu();
                    usuario.atualizahis();

                    //chama a tela de login                        
                    Form c = new Principal();
                    c.Show();
                }
            }      
            //fecha a tela de deletar usuario
            this.Close();
        }
    }
}
