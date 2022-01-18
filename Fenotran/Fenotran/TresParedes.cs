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
    public partial class TresParedes : Form
    {
        Image temp, metro, inicio;

        double q, t1, t2, t3, t4, t5, t6, t61, t62, t63, t64, t65, t11, t12, t13, t14, t15, l1, k1, l2, k2, l3, k3, h1, h2, rt, delta, deltatemp, rt1, rt2, rt3, rth1, rth2;
        string unidadefx, unidadert, unidadek, unidadel, unidadeh;

        private void Calcular_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(Rbtfluxo.Checked) && !(RbtT1.Checked) && !(RbtT5.Checked) && !(RbtL1.Checked) && !(RbtK1.Checked) && !(RbtL2.Checked) && !(RbtK2.Checked) && !(RbtL3.Checked) && !(RbtK3.Checked) && !(RbtH1.Checked) && !(RbtH2.Checked))
            {
                MessageBox.Show("Selecione algum item a ser calculado");
            }

            else if (!(CheckKcal.Checked) && !(CheckW.Checked))
            {
                MessageBox.Show("Selecione a unidade correspondente");
            }
        }

        private void TresParedes_Load(object sender, EventArgs e)
        {
            temp = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PTemperatura.jpg");
            metro = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\PMetro.jpg");
            inicio = Image.FromFile(Environment.CurrentDirectory + "\\BancodeDados\\Painel.jpg");
        }

        private void K13p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void L23p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void K23p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void L33p_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (L3.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (L3.Text.Contains("-"))
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

        private void K33p_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (K4.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (K4.Text.Contains("-"))
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

        private void H13p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void H23p_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void L13p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void temp63p_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (T6.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //Verifica se já existe alguma vírgula na string
                if (T6.Text.Contains("-"))
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

        private void temp13p_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fluxo3p_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (fluxo.Text.Contains(","))
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

        public TresParedes()
        {
            InitializeComponent();
            fluxo.Text = "21,627";
            T1.Text = "25";
            T6.Text = "10";
            L1.Text = "0,004";
            K1.Text = "0,78";
            L2.Text = "0,01";
            K2.Text = "0,025";
            L3.Text = "0,004";
            K4.Text = "0,78";
            H1.Text = "5";
            H2.Text = "12";
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Form x = new R1TresParedes();
            Form z = new R2TresParedes();
            try
            {
                if (Rbtfluxo.Checked)
                {
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    q = delta / rt;
                }

                else if (RbtT1.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    deltatemp = q * rt;
                    t1 = t6 + deltatemp;
                    t11 = t6 - deltatemp;
                }

                else if (RbtT5.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    deltatemp = q * rt;
                    t6 = t1 + deltatemp;
                    t61 = t1 - deltatemp;
                }

                else if (RbtL1.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    l1 = ((delta * k1) - (k1 * q * rt)) / q;
                }

                else if (RbtK1.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    k1 = (-1 * (q * l1)) / ((rt * q) - delta);
                }

                else if (RbtL2.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l1 / k1) + (l3 / k3) + (1 / h2);
                    l2 = ((delta * k2) - (k2 * q * rt)) / q;
                }

                else if (RbtK2.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l1 / k1) + (l3 / k3) + (1 / h2);
                    k2 = (-1 * (q * l2)) / ((rt * q) - delta);
                }

                else if (RbtL3.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l2 / k2) + (l1 / k1) + (1 / h2);
                    l3 = ((delta * k3) - (k3 * q * rt)) / q;
                }

                else if (RbtK3.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    h1 = float.Parse(H1.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l2 / k2) + (l1 / k1) + (1 / h2);
                    k3 = (-1 * (q * l3)) / ((rt * q) - delta);
                }

                else if (RbtH1.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h2 = float.Parse(H2.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (l1 / k1) + (l2 / k2) + (l3 / k3) + (1 / h2);
                    h1 = q / (delta - (rt * q));
                }

                else if (RbtH2.Checked)
                {
                    q = float.Parse(fluxo.Text);
                    t1 = float.Parse(T1.Text);
                    t6 = float.Parse(T6.Text);
                    l1 = float.Parse(L1.Text);
                    k1 = float.Parse(K1.Text);
                    l2 = float.Parse(L2.Text);
                    k2 = float.Parse(K2.Text);
                    l3 = float.Parse(L3.Text);
                    k3 = float.Parse(K4.Text);
                    h1 = float.Parse(H1.Text);

                    if (t1 > t6)
                    {
                        delta = t1 - t6;
                    }

                    else
                    {
                        delta = t6 - t1;
                    }
                    rt = (1 / h1) + (l1 / k1) + (l2 / k2) + (l3 / k3);
                    h2 = q / (delta - (rt * q));
                }
                
                if (CheckKcal.Checked)
                {
                    unidadefx = "kcal/h (p/m²)";
                    unidadert = "hºC/kcal";
                    unidadek = "kcal/hmºC";
                    unidadel = "m";
                    unidadeh = "kcal/hm²ºC";
                }

                else if(CheckW.Checked)
                {
                    unidadefx = "W (p/m²)";
                    unidadert = "ºC/W";
                    unidadek = "W/mºC";
                    unidadel = "m";
                    unidadeh = "W/m²ºC";
                }

                rt1 = l1 / k1;
                rt2 = l2 / k2;
                rt3 = l3 / k3;
                rth1 = 1 / h1;
                rth2 = 1 / h2;

                if (RbtT1.Checked)
                {
                    t2 = -1 * ((q - (t1 * h1)) / h1);
                    t3 = -1 * ((q * (l1 / k1)) - t2);
                    t4 = -1 * ((q * (l2 / k2)) - t3);
                    t5 = -1 * ((q * (l3 / k3)) - t4);
                    t15 = -1 * ((q - (t6 * h2)) / h2);
                    t12 = ((q + (t11 * h1)) / h1);
                    t13 = (q * (l1 / k1)) + t12;
                    t14 = (q * (l2 / k2)) + t13;

                    salvar1(Math.Round(t11, 2).ToString(), Math.Round(t12, 2).ToString(), Math.Round(t13, 2).ToString(), Math.Round(t14, 2).ToString(), Math.Round(t15, 2).ToString(), Math.Round(t6, 2).ToString());
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rt1, 6).ToString(), Math.Round(rt2, 6).ToString(), Math.Round(rt3, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(k3, 6).ToString(), Math.Round(l3, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), Math.Round(t6, 2).ToString(), unidadefx, unidadert, unidadek, unidadel, unidadeh);
                    z.Show();
                    this.Close();
                }

                else if (RbtT5.Checked)
                {
                    t2 = (q + (t1 * h1)) / h1;
                    t3 = (q * (l1 * k1)) + t2;
                    t4 = (q * (l2 / k2)) + t3;
                    t5 = (q * (l3 / k3)) + t4;
                    t62 = (((t1 * h1) - q) / h1);
                    t63 = -1 * ((q * (l1 / k1)) - t62);
                    t64 = -1 * ((q * (l2 / k2)) - t63);
                    t65 = -1 * ((q * (l3 / k3)) - t64);

                    salvar1(Math.Round(t1, 2).ToString(), Math.Round(t62, 2).ToString(), Math.Round(t63, 2).ToString(), Math.Round(t64, 2).ToString(), Math.Round(t65, 2).ToString(), Math.Round(t61, 2).ToString());
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rt1, 6).ToString(), Math.Round(rt2, 6).ToString(), Math.Round(rt3, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(k3, 6).ToString(), Math.Round(l3, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), Math.Round(t6, 2).ToString(), unidadefx, unidadert, unidadek, unidadel, unidadeh);
                    z.Show();
                    this.Close(); 
                }

                else
                {
                    if (t1 > t6)
                    {
                        t2 = -1 * ((q - (t1 * h1)) / h1);
                        t3 = -1 * ((q * (l1 / k1)) - t2);
                        t4 = -1 * ((q * (l2 / k2)) - t3);
                        t5 = -1 * ((q * (l3 / k3)) - t4);
                    }
                    else
                    {
                        t5 = -1 * ((q - (t6 * h2)) / h2);
                        t4 = -1 * ((q * (l3 / k3)) - t5);
                        t3 = -1 * ((q * (l2 / k2)) - t4);
                        t2 = -1 * ((q * (l1 / k1)) - t3);
                    }
                    salvar(Math.Round(q, 6).ToString(), Math.Round(rt1, 6).ToString(), Math.Round(rt2, 6).ToString(), Math.Round(rt3, 6).ToString(), Math.Round(rth1, 6).ToString(), Math.Round(rth2, 6).ToString(), Math.Round(k1, 6).ToString(), Math.Round(l1, 6).ToString(), Math.Round(k2, 6).ToString(), Math.Round(l2, 6).ToString(), Math.Round(k3, 6).ToString(), Math.Round(l3, 6).ToString(), Math.Round(h1, 6).ToString(), Math.Round(h2, 6).ToString(), Math.Round(t1, 2).ToString(), Math.Round(t2, 2).ToString(), Math.Round(t3, 2).ToString(), Math.Round(t4, 2).ToString(), Math.Round(t5, 2).ToString(), Math.Round(t6, 2).ToString(), unidadefx, unidadert, unidadek, unidadel, unidadeh);
                    x.Show();
                    this.Close();
                }
            }

            catch
            {
                MessageBox.Show("Para prosseguir, preencha os campos corretamente!");
            }
            
        }

        private void Rbtfluxo_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = false;
            fluxo.Clear();
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtT1_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = false;
            T1.Clear();
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtT5_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = false;
            T6.Clear();
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtL1_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = false;
            L1.Clear();
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }
        
        private void RbtK1_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = false;
            K1.Clear();
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtL2_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = false;
            L2.Clear();
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtK2_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = false;
            K2.Clear();
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtL3_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = false;
            L3.Clear();
            K4.Enabled = true;
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtK3_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = false;
            K4.Clear();
            H1.Enabled = true;
            H2.Enabled = true;
        }

        private void RbtH1_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
            H1.Enabled = false;
            H1.Clear();
            H2.Enabled = true;
        }

        private void RbtH2_CheckedChanged(object sender, EventArgs e)
        {
            fluxo.Enabled = true;
            T1.Enabled = true;
            T6.Enabled = true;
            L1.Enabled = true;
            K1.Enabled = true;
            L2.Enabled = true;
            K2.Enabled = true;
            L3.Enabled = true;
            K4.Enabled = true;
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

        private void salvar(string q, string w, string e, string r, string t, string y, string u, string i, string o, string p, string a, string s, string d, string f, string g, string h, string j, string k, string l, string ç, string z, string x, string c, string v, string b)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}#{12}#{13}#{14}#{15}#{16}#{17}#{18}#{19}#{20}#{21}#{22}#{23}#{24}", q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, ç, z, x, c, v, b);
                op.Close();
            }
        }

        private void salvar1(string q, string w, string e, string r, string t, string y)
        {
            using (StreamWriter op = new StreamWriter(Environment.CurrentDirectory + "\\BancodeDados\\arquivo1.txt"))
            {
                op.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}", q, w, e, r, t, y);
                op.Close();
            }
        }

    }
}
