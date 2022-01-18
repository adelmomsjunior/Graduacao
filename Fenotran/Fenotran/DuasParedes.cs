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
    public partial class DuasParedes : Form
    {
        Image temp, metro, inicio;

        double q, t1, t2, t3, t4, t5, t11, t12, t13, t14, t51, t52, t53, t54, l1, k1, l2, k2, h1, h2, rt, delta, deltatemp, rtk1, rtk2, rth1, rth2;
        string unifx,unirt,unik,unil,unih;

        private void Fluxo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (Fluxo.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) )
            {
                e.Handled = true;
            }
        }

        private void DuasParedes_Load(object sender, EventArgs e)
        {
            temp = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PTemperatura.jpg");
            metro = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PMetro.jpg");
            inicio = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Painel.jpg");
        }

        private void T1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (T1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (T1.Text.Contains("-"))
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

        private void T5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (T5.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (T5.Text.Contains("-"))
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

        private void L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (L1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (L1.Text.Contains("-"))
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

        private void K1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (K1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (K1.Text.Contains("-"))
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

        private void L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (L2.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (L2.Text.Contains("-"))
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

        private void K2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (K2.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (K2.Text.Contains("-"))
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

        private void H1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (H1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (H1.Text.Contains("-"))
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

        private void H2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (H2.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (H2.Text.Contains("-"))
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

        private void TxtConverte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtConverte.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (TxtConverte.Text.Contains("-"))
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

        private void Calcular_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(Rbfluxo.Checked) && !(RbT1.Checked) && !(RbT5.Checked) && !(RbL1.Checked) && !(RbK1.Checked) && !(RbL2.Checked) && !(RbK2.Checked) && !(RbH1.Checked) && !(Rbh2.Checked))
            {
                MessageBox.Show("Selecione algum item a ser calculado");
            }

            else if (!(CheckKcal.Checked) && !(CheckW.Checked))
            {
                MessageBox.Show("Selecione a unidade correspondente");
            }
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

        private void BtConversao_Click(object sender, EventArgs e)
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

        public DuasParedes()
        {
            InitializeComponent();
            Fluxo.Text = "1480,6";
            T1.Text = "1700";
            T5.Text = "27";
            L1.Text = "0,20";
            K1.Text = "1,2";
            L2.Text = "0,13";
            K2.Text = "0,15";
            H1.Text = "58";
            H2.Text = "12,5";
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Form g = new R1DuasParedes();
            Form h = new R2DuasParedes();
            
            try
            {
                if (Rbfluxo.Checked)
                {
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (1 / h2);
                    q = delta / rt;

                }

                else if (RbT1.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (1 / h2);
                    deltatemp = q * rt;
                    t1 = t5 + deltatemp;
                    t11 = t5 - deltatemp;
                }

                else if (RbT5.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (1 / h2);
                    deltatemp = q * rt;
                    t5 = t1 + deltatemp;
                    t51 = t1 - deltatemp;

                }

                else if (RbL1.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (1 / h1) + (l2 / k2) + (1 / h2);
                    l1 = ((delta * k1) - (k1 * q * rt)) / q;
                }

                else if (RbK1.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (1 / h1) + (l2 / k2) + (1 / h2);
                    k1 = (-1 * (q * l1)) / ((rt * q) - delta);
                }

                else if (RbL2.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (1 / h1) + (l1 / k1) + (1 / h2);
                    l2 = ((delta * k2) - (k2 * q * rt)) / q;
                }

                else if (RbK2.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (1 / h1) + (l1 / k1) + (1 / h2);
                    k2 = (-1 * (q * l2)) / ((rt * q) - delta);
                }

                else if (RbH1.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (l1 / k1) + (l2 / k2) + (1 / h2);
                    h1 = q / (delta - (rt * q));
                }

                else if (Rbh2.Checked)
                {
                    q = float.Parse(Fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t5 = float.Parse(T5.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    h1 = float.Parse(H1.Text);

                    if (t1 > t5)
                    {
                        delta = t1 - t5;
                    }
                    else
                    {
                        delta = t5 - t1;
                    }

                    rt = (l1 / k1) + (l2 / k2) + (1 / h1);
                    h2 = q / (delta - (rt * q));
                }

                if (CheckKcal.Checked)
                {
                    unifx = "kcal/h (p/m²)";
                    unirt = "hºC/kcal";
                    unik = "kcal/hmºC";
                    unil = "m";
                    unih = "kcal/hm²ºC";
                }

                else if (CheckW.Checked)
                {

                    unifx = "W (p/m²)";
                    unirt = "ºC/W";
                    unik = "W/mºC";
                    unil = "m";
                    unih = "W/m²ºC";

                }

                rtk1 = l1 / k1;
                rtk2 = l2 / k2;
                rth1 = 1 / h1;
                rth2 = 1 / h2;

                if (RbT1.Checked)
                {
                    t2 = -1 * ((q - (h1 * t1)) / h1);
                    t3 = -1 * ((q * (l1 / k1)) - t2);
                    t4 = ((q + (h2 * t5)) / h2);
                    t12 = ((q + (h1 * t11)) / h1);
                    t13 = ((q * l1) + (t12 * k1)) / k1;
                    t14 = -1 * ((q - (t5 * h2)) / h2);
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rtk1, 6).ToString(), Math.Round(rtk2, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), unifx, unirt, unik, unil, unih);
                    salvar2(Math.Round(t11, 2).ToString(), Math.Round(t12, 2).ToString(), Math.Round(t13, 2).ToString(), Math.Round(t14, 2).ToString(), Math.Round(t5, 2).ToString());
                    h.Show();
                    this.Close();
                }

                else if (RbT5.Checked)
                {
                    t4 = -1 * ((q - (t5 * h2)) / h2);
                    t3 = -1 * (((q * l2) - (t4 * k2)) / k2);
                    t2 = (q + (t1 * h1)) / h1;
                    t54 = (q + (t51 * h2)) / h2;
                    t53 = ((q * l2) + (t54 * k2)) / k2;
                    t52 = -1 * ((q - (t1 * h1)) / h1);
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rtk1, 6).ToString(), Math.Round(rtk2, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), unifx, unirt, unik, unil, unih);
                    salvar2(Math.Round(t1, 2).ToString(), Math.Round(t52, 2).ToString(), Math.Round(t53, 2).ToString(), Math.Round(t54, 2).ToString(), Math.Round(t51, 2).ToString());
                    h.Show();
                    this.Close();

                }

                else
                {
                    if (t1 > t5)
                    {
                        t2 = -1 * ((q - (h1 * t1)) / h1);
                        t3 = -1 * ((q * (l1 / k1)) - t2);
                        t4 = ((q + (h2 * t5)) / h2);

                    }
                    else
                    {
                        t4 = -1 * ((q - (h2 * t5)) / h2);
                        t3 = -1 * ((q * (l2 / k2)) - t4);
                        t2 = ((q + (h1 * t1)) / h1);

                    }
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rtk1, 6).ToString(), Math.Round(rtk2, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), unifx, unirt, unik, unil, unih);
                    g.Show();
                    this.Close();
                }
            }

            catch
            {
                MessageBox.Show("Para prosseguir, preencha os campos corretamente!");
            }
        }

        private void Rbfluxo_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = false;
            Fluxo.Clear();
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbT1_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = false;
            T1.Clear();
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbT5_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = false;
            T5.Clear();
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbL1_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = false;
            L1.Clear();
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbK1_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = false;
            K1.Clear();
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbL2_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = false;
            L2.Clear();
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbK2_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = false;
            K2.Clear();
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbH1_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = false;
            H1.Clear();
            H2.Enabled = true;
        }

        private void Rbh2_CheckedChanged(object sender, EventArgs e)
        {
            Fluxo.Enabled = true;
            T1.Enabled = true;
            T5.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = false;
            H2.Clear();
        }

        private void CheckKcal_CheckedChanged(object sender, EventArgs e)
        {
            CheckW.Checked = false;
        }

        private void CheckW_CheckedChanged(object sender, EventArgs e)
        {
            CheckKcal.Checked = false;
        }
        
        private void salvar (string q, string w, string e, string r, string t, string y, string u, string i, string o, string p, string a, string s, string d, string f, string g, string h, string j, string k, string l, string z,string x)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}#{12}#{13}#{14}#{15}#{16}#{17}#{18}#{19}#{20}", q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z,x);
                op.Close();
            }
        }

        private void salvar2(string q, string w, string e, string r, string t)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo1.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}#{4}", q, w, e, r, t);
                op.Close();
            }
        }
    }
}
