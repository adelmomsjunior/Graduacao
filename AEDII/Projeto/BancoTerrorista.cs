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
    public partial class BancoTerrorista : Form
    {
        public BancoTerrorista()
        {
            InitializeComponent();
            picadterror.Visible = false;
            // adiciona os dados ao combobox (cmbancoterrorista)
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    cmbancoterrorista.Items.Add(d[0]);
                 }
            }
        }

        private void cmbancoterrorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lê o arquivo e distribui para os campos determinados.
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    if (cmbancoterrorista.SelectedItem.Equals(d[0]))
                    {
                        txtcadstatus.Text = d[1];
                        txtcadidade.Text = d[2];
                        txtcadaltura.Text = d[3];
                        txtcadpeso.Text = d[4];
                        txtcadnatural.Text = d[5];
                        txtcadmarcas.Text =d[6]; 
                        txtcadobs.Text = d[7];
                        picadterror.ImageLocation = d[8];
                        picadterror.Visible = true;
                    }
                }
            }
        }

        private void btcadterroretorna_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela 
            this.Close();
        }
    }
}