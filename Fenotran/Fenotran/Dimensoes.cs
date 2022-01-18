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
    public partial class Dimensoes : Form
    {
        public Dimensoes()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            double km = 0, hm = 0, dam = 0, m = 0, dec = 0, cm = 0, mm = 0, pol = 0;

            if (RbKm.Checked)
            {
                km = double.Parse(txtConverter.Text);
                hm = km * 10;
                dam = km * 100;
                m = km * 1000;
                dec = km * 10000;
                cm = km * 100000;
                mm = km * 1000000;
                pol = (km * 1000) / 0.0254;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbHm.Checked)
            {
                hm = double.Parse(txtConverter.Text);
                km = hm / 10;
                dam = hm * 10;
                m = hm * 100;
                dec = hm * 1000;
                cm = hm * 10000;
                mm = hm * 100000;
                pol = (hm * 100) / 0.0254;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbDam.Checked)
            {
                dam = double.Parse(txtConverter.Text);
                km = dam / 100;
                hm = dam / 10;
                m = dam * 10;
                dec = dam * 100;
                cm = dam * 1000;
                mm = dam * 10000;
                pol = (dam * 10) / 0.0254;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbM.Checked)
            {
                m = double.Parse(txtConverter.Text);
                km = m / 1000;
                hm = m / 100;
                dam = m / 10;
                dec = m * 10;
                cm = m * 100;
                mm = m * 1000;
                pol = m / 0.0254;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbDec.Checked)
            {
                dec = double.Parse(txtConverter.Text);
                km = dec / 10000;
                hm = dec / 1000;
                dam = dec / 100;
                m = dec / 10;
                cm = dec * 10;
                mm = dec * 100;
                pol = dec / 0.254;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbCm.Checked)
            {
                cm = double.Parse(txtConverter.Text);
                km = cm / 100000;
                hm = cm / 10000;
                dam = cm / 1000;
                m = cm / 100;
                dec = cm / 10;
                mm = cm * 10;
                pol = cm / 2.54;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbMm.Checked)
            {
                mm = double.Parse(txtConverter.Text);
                km = mm / 1000000;
                hm = mm / 100000;
                dam = mm / 10000;
                m = mm / 1000;
                dec = mm / 100;
                cm = mm / 10;
                pol = mm / 25.4;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }

            else if (RbPol.Checked)
            {
                pol = double.Parse(txtConverter.Text);

                km = pol * 0.0000254;
                hm = pol * 0.000254;
                dam = pol * 0.00254;
                m = pol * 0.0254;
                dec = pol * 0.254;
                cm = pol * 2.54;
                mm = pol * 25.4;

                Km.Text = Math.Round(km, 6).ToString();
                Hm.Text = Math.Round(hm, 6).ToString();
                Dam.Text = Math.Round(dam, 6).ToString();
                M.Text = Math.Round(m, 6).ToString();
                Dec.Text = Math.Round(dec, 6).ToString();
                Cm.Text = Math.Round(cm, 6).ToString();
                Mm.Text = Math.Round(mm, 6).ToString();
                Pol.Text = Math.Round(pol, 6).ToString();
            }
        }

        private void BtCalcular_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(RbKm.Checked) && !(RbHm.Checked) && !(RbDam.Checked) && !(RbM.Checked) && !(RbDec.Checked) && !(RbCm.Checked) && !(RbMm.Checked) && !(RbPol.Checked))
            {
                MessageBox.Show("Selecione a Unidade de medida a ser convertida");
            }

            if (txtConverter.Text.Equals(""))
            {
                MessageBox.Show("Digite a medida e ser convertida");
            }
        }

        private void txtConverter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtConverter.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
