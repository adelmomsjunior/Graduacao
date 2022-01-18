using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenotran
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            Data.Select();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 2].Close();
        }

        private void umaParedePlanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new UmaParede();
            a.Show();
            this.Close();
        }

        private void duasParedesPlanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new DuasParedes();
            a.Show();
            this.Close();
        }

        private void trêsParedesPlanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new TresParedes();
            a.Show();
            this.Close();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Temperatura();
            a.Show();
            this.Close();
        }

        private void dimensõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Dimensoes();
            a.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Data.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void umaParedeCilíndricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Cilindrico();
            a.Show();
            this.Close();
        }
    }
}
