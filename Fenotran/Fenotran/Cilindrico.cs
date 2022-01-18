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

namespace Fenotran
{
    public partial class Cilindrico : Form
    {
        Image temp, metro, inicio;
                
        double q, t1, t2, t3, t4, r1, r2, k1, l, h1, h2, t11, t12, t13, t42, t43, t44, rt, rcond, rconv1, rconv2, delta;
        string unidadefx, unidadert, unidadek, unidadel, unidadeh;

        private void TxtT4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtT4.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtT4.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtR1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtR1.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtR2.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtR2.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtK1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtK1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtK1.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtL.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtL.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtH1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtH1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtH1.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtH2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtH2.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtH2.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void Cilindrico_Load(object sender, EventArgs e)
        {
            temp = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PTemperatura.jpg");
            metro = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PMetro.jpg");
            inicio = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Painel.jpg");
        }

        private void TxtT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtT1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtT1.Text.Contains("-"))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }

        private void TxtFluxo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtFluxo.Text.Contains(","))
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

        private void BtCalcular_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(CheckKcal.Checked) && !(CheckW.Checked))
            {
                MessageBox.Show("Selecione a unidade correspondente");
            }

            else if(!(RbFluxo.Checked) && !(RbT1.Checked) && !(RbT4.Checked) && !(RbR1.Checked) && !(RbR2.Checked) && !(RbK1.Checked) && !(RbL.Checked) && !(RbH1.Checked) && !(RbH2.Checked))
            {
                MessageBox.Show("Selecione algum item a ser calculado");
            }
        }

        public Cilindrico()
        {
            InitializeComponent();

            TxtFluxo.Text = "532,05";
            TxtT1.Text = "177";
            TxtT4.Text = "20";
            TxtR1.Text = "0,005";
            TxtR2.Text = "0,006";
            TxtK1.Text = "0,20";
            TxtL.Text = "1";
            TxtH1.Text = "10";
            TxtH2.Text = "20";
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void CheckKcal_CheckedChanged(object sender, EventArgs e)
        {
            CheckW.Checked = false;
        }

        private void CheckW_CheckedChanged(object sender, EventArgs e)
        {
            CheckKcal.Checked = false;
        }

        private void RbFluxo_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = false;
            TxtFluxo.Clear();
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbT1_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = false;
            TxtT1.Clear();
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbT4_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = false;
            TxtT4.Clear();
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbR1_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = false;
            TxtR1.Clear();
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbR2_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = false;
            TxtR2.Clear();
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbK1_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = false;
            TxtK1.Clear();
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbL_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = false;
            TxtL.Clear();
            TxtH1.Enabled = true;
            TxtH2.Enabled = true;
        }

        private void RbH1_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = false;
            TxtH1.Clear();
            TxtH2.Enabled = true;
        }

        private void RbH2_CheckedChanged(object sender, EventArgs e)
        {
            TxtFluxo.Enabled = true;
            TxtT1.Enabled = true;
            TxtT4.Enabled = true;
            TxtR1.Enabled = true;
            TxtR2.Enabled = true;
            TxtK1.Enabled = true;
            TxtL.Enabled = true;
            TxtH1.Enabled = true;
            TxtH2.Enabled = false;
            TxtH2.Clear();
        }

        private void BtTemperatura_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = temp;
            RbFah.Visible = true;
            RbKel.Visible = true;
            RbDec.Visible = false;
            RbDec.Checked = false;
            RbCent.Visible = false;
            RbCent.Checked = false;
            RbMili.Visible = false;
            RbMili.Checked = false;
            RbPol.Visible = false;
            RbPol.Checked = false;

            TxtConverte.Visible = true;
            TxtConverte.Clear();
            TxtConvertido.Visible = true;
            TxtConvertido.Clear();

            BtCalcularConv.Visible = true;

            RbFah.Location = new Point(184, 158);
            RbKel.Location = new Point(424, 158);
            BtCalcularConv.Location = new Point(274, 205);
        }

        private void BtDimensao_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = metro;
            RbFah.Visible = false;
            RbFah.Checked = false;
            RbKel.Visible = false;
            RbKel.Checked = false;
            RbDec.Visible = true;
            RbCent.Visible = true;
            RbMili.Visible = true;
            RbPol.Visible = true;

            TxtConverte.Visible = true;
            TxtConverte.Clear();
            TxtConvertido.Visible = true;
            TxtConvertido.Clear();

            BtCalcularConv.Visible = true;
            BtCalcularConv.Location = new Point(282, 195);
            RbDec.Location = new Point(53, 158);
            RbCent.Location = new Point(224, 158);
            RbMili.Location = new Point(393, 158);
            RbPol.Location = new Point(554, 158);
        }

        private void BtSairConv_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = inicio;
            panel1.Visible = false;
            RbFah.Checked = false;
            RbKel.Checked = false;
            RbDec.Checked = false;
            RbCent.Checked = false;
            RbMili.Checked = false;
            RbPol.Checked = false;

            TxtConverte.Visible = false;
            TxtConverte.Clear();
            TxtConvertido.Visible = false;
            TxtConvertido.Clear();

            BtCalcularConv.Visible = false;
        }

        private void BtConv_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(639, 420);
            panel1.Visible = true;
            RbFah.Visible = false;
            RbKel.Visible = false;
            RbDec.Visible = false;
            RbCent.Visible = false;
            RbMili.Visible = false;
            RbPol.Visible = false;

            TxtConverte.Visible = false;
            TxtConverte.Clear();
            TxtConvertido.Visible = false;
            TxtConvertido.Clear();
            BtCalcularConv.Visible = false;
        }

        private void BtCalcularConv_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius, fahrenheit, kelvin, metro, deci, cent, mili, pol;

                if (RbFah.Checked)
                {
                    fahrenheit = float.Parse(TxtConverte.Text);
                    celsius = (fahrenheit - 32) / 1.8;
                    TxtConvertido.Text = Math.Round(celsius, 3).ToString();
                }

                else if (RbKel.Checked)
                {
                    kelvin = float.Parse(TxtConverte.Text);
                    celsius = kelvin - 273;
                    TxtConvertido.Text = Math.Round(celsius, 3).ToString();
                }

                else if (RbDec.Checked)
                {
                    deci = float.Parse(TxtConverte.Text);
                    metro = deci / 10;
                    TxtConvertido.Text = Math.Round(metro, 3).ToString();
                }

                else if (RbCent.Checked)
                {
                    cent = float.Parse(TxtConverte.Text);
                    metro = cent / 100;
                    TxtConvertido.Text = Math.Round(metro, 3).ToString();
                }

                else if (RbMili.Checked)
                {
                    mili = float.Parse(TxtConverte.Text);
                    metro = mili / 1000;
                    TxtConvertido.Text = Math.Round(metro, 3).ToString();
                }

                else if (RbPol.Checked)
                {
                    pol = float.Parse(TxtConverte.Text);
                    metro = pol * 0.0254;
                    TxtConvertido.Text = Math.Round(metro, 3).ToString();
                }
            }

            catch
            {
                MessageBox.Show("Prencha o campo corretamente");
            }
        }

        private void BtCalcularConv_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (TxtConverte.Text.Equals(""))
                {
                    MessageBox.Show("Preencha o campo corretamente");
                }

                else if ((RbKel.Checked) && ((double.Parse(TxtConverte.Text)) < 0))
                {
                    MessageBox.Show("Não e possivel converter, pois não existe temperatura abaixo de 0 Absoluto");
                    TxtConverte.Clear();
                    TxtConvertido.Clear();
                    RbKel.Checked = false;
                }

                else if ((RbFah.Checked) && ((double.Parse(TxtConverte.Text)) < -459))
                {
                    MessageBox.Show("Não e possivel converter, pois não existe temperatura abaixo de 0 Absoluto");
                    TxtConverte.Clear();
                    TxtConvertido.Clear();
                    RbFah.Checked = false;
                }

                else if (!(RbFah.Checked) && !(RbKel.Checked) && !(RbDec.Checked) && !(RbCent.Checked) && !(RbMili.Checked) && !(RbPol.Checked))
                {
                    MessageBox.Show("Selecione a unidade corretamente");
                }
            }

            catch
            {
                MessageBox.Show("Preencha o campo corretamente");
                TxtConverte.Clear();
                TxtConvertido.Clear();
            }
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            Form a = new R1Cilindrico();
            Form b = new R2Cilindrico();

            try
            {
                if (RbFluxo.Checked)
                {
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;
                    rcond = Math.Log(r2 / r1) / (2 * Math.PI * k1 * l);
                    rt = rconv1 + rcond + rconv2;

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }

                    q = delta / rt;
                }

                else if (RbT1.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;
                    rcond = Math.Log(r2 / r1) / (2 * Math.PI * k1 * l);
                    rt = rconv1 + rcond + rconv2;

                    delta = q * rt;
                    t1 = t4 + delta;
                    t11 = t4 - delta;
                }

                else if (RbT4.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;
                    rcond = Math.Log(r2 / r1) / (2 * Math.PI * k1 * l);
                    rt = rconv1 + rcond + rconv2;

                    delta = q * rt;
                    t4 = t1 + delta;
                    t44 = t1 - delta;
                }

                else if (RbR1.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }

                    rt = delta / q;
                    rcond = rt - rconv1 - rconv2;

                    r1 = r2 / Math.Exp(2 * Math.PI * k1 * l * rcond);
                }

                else if (RbR2.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }

                    rt = delta / q;
                    rcond = rt - rconv1 - rconv2;

                    r2 = r1 * Math.Exp(2 * Math.PI * k1 * l * rcond);
                }

                else if (RbK1.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }

                    rt = delta / q;
                    rcond = rt - rconv1 - rconv2;

                    k1 = Math.Log(r2 / r1) / (2 * Math.PI * l * rcond);
                }

                else if (RbL.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    h1 = float.Parse(TxtH1.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv1 = 1 / h1;
                    rconv2 = 1 / h2;

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }

                    rt = delta / q;
                    rcond = rt - rconv1 - rconv2;

                    l = Math.Log(r2 / r1) / (2 * Math.PI * k1 * rcond);
                }

                else if (RbH1.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h2 = float.Parse(TxtH2.Text);

                    rconv2 = 1 / h2;
                    rcond = Math.Log(r2 / r1) / (2 * Math.PI * k1 * l);

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }
                    rt = delta / q;
                    rconv1 = rt - rcond - rconv2;
                    h1 = 1 / rconv1;
                }

                else if (RbH2.Checked)
                {
                    q = float.Parse(TxtFluxo.Text);
                    t1 = float.Parse(TxtT1.Text);
                    t4 = float.Parse(TxtT4.Text);
                    r1 = float.Parse(TxtR1.Text);
                    r2 = float.Parse(TxtR2.Text);
                    k1 = float.Parse(TxtK1.Text);
                    l = float.Parse(TxtL.Text);
                    h1 = float.Parse(TxtH1.Text);

                    rconv1 = 1 / h1;
                    rcond = Math.Log(r2 / r1) / (2 * Math.PI * k1 * l);

                    if (t1 > t4)
                    {
                        delta = t1 - t4;
                    }

                    else
                    {
                        delta = t4 - t1;
                    }
                    rt = delta / q;
                    rconv2 = rt - rcond - rconv1;
                    h2 = 1 / rconv2;
                }

                if (CheckKcal.Checked)
                {
                    unidadefx = "kcal/h (p/m²)";
                    unidadert = "hºC/kcal";
                    unidadek = "kcal/hmºC";
                    unidadel = "m";
                    unidadeh = "kcal/hm²ºC";
                }

                else if (CheckW.Checked)
                {
                    unidadefx = "W (p/m²)";
                    unidadert = "ºC/W";
                    unidadek = "W/mºC";
                    unidadel = "m";
                    unidadeh = "W/m²ºC";
                }

                if (RbT1.Checked)
                {
                    t2 = -1 * ((q - (h1 * t1)) / h1);
                    t3 = (q + (h2 * t4)) / h2;
                    t12 = (q + (h1 * t11)) / h1;
                    t13 = -1 * ((q - (h2 * t4)) / h2);

                    salvar(Math.Round(q, 6).ToString(), Math.Round(rcond, 6).ToString(), Math.Round(rconv1, 6).ToString(), Math.Round(rconv2, 6).ToString(), Math.Round(r1, 6).ToString(), Math.Round(r2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), unidadefx, unidadert, unidadel, unidadek, unidadeh);
                    salvar1(Math.Round(t11, 2).ToString(), Math.Round(t12, 2).ToString(), Math.Round(t13, 2).ToString(), Math.Round(t4, 2).ToString());
                    b.Show();
                    this.Close();

                }

                else if (RbT4.Checked)
                {
                    t2 = (q + (t1 * h1)) / h1;
                    t3 = -1 * ((q - (t4 * h2)) / h2);
                    t42 = -1 * ((q - (t1 * h1)) / h1);
                    t43 = (q + (t44 * h2)) / h2;

                    salvar(Math.Round(q, 6).ToString(), Math.Round(rcond, 6).ToString(), Math.Round(rconv1, 6).ToString(), Math.Round(rconv2, 6).ToString(), Math.Round(r1, 6).ToString(), Math.Round(r2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), unidadefx, unidadert, unidadel, unidadek, unidadeh);
                    salvar1(Math.Round(t1, 2).ToString(), Math.Round(t42, 2).ToString(), Math.Round(t43, 2).ToString(), Math.Round(t44, 2).ToString());
                    b.Show();
                    this.Close();

                }

                else
                {
                    if (t1 > t4)
                    {
                        t2 = -1 * ((q - (h1 * t1)) / h1);
                        t3 = (q + (h2 * t4)) / h2;
                    }

                    else
                    {
                        t2 = (q + (h1 * t1)) / h1;
                        t3 = -1 * ((q - (h2 * t4)) / h2);
                    }
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rcond, 6).ToString(), Math.Round(rconv1, 6).ToString(), Math.Round(rconv2, 6).ToString(), Math.Round(r1, 6).ToString(), Math.Round(r2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), unidadefx, unidadert, unidadel, unidadek, unidadeh);
                    a.Show();
                    this.Close();

                }
            }

            catch
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        private void salvar(string q, string w, string e, string r, string t, string y, string u, string i, string o, string p, string a, string s, string d, string f, string g, string h, string j, string k, string l)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}#{12}#{13}#{14}#{15}#{16}#{17}#{18}", q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l);
                op.Close();
            }
        }

        private void salvar1(string q, string w, string e, string r)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo1.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}", q, w, e, r);
                op.Close();
            }
        }
    }
}
