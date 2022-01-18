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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Form a = new TelaInicial();
            a.Show();
            this.Close();
        }
        
        private void TxtConverter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtConverter.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            else if (e.KeyChar == '-')
            {
                //troca o . pela virgula
                //e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtConverter.Text.Contains("-"))
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
        
        private void Calcular_Click(object sender, EventArgs e)
        {

            double cel, fah, kel;

            if (RbCelsius.Checked)
            {
                cel = double.Parse(TxtConverter.Text);
                fah = (cel * 1.8) + 32;
                kel = cel + 273;

                Celcius.Text = Math.Round(cel, 2).ToString();
                Fahrenheit.Text = Math.Round(fah, 2).ToString();
                Kelvin.Text = Math.Round(kel, 2).ToString();
            }

            if (RbFahrenheit.Checked)
            {
                fah = double.Parse(TxtConverter.Text);
                cel = (fah - 32) / 1.8;
                kel = ((5 * fah) + 2297) / 9;

                Celcius.Text = Math.Round(cel, 2).ToString();
                Fahrenheit.Text = Math.Round(fah, 2).ToString();
                Kelvin.Text = Math.Round(kel, 2).ToString();
            }

            if (RbKelvin.Checked)
            {
                kel = double.Parse(TxtConverter.Text);
                cel = kel - 273;
                fah = ((9 * kel) - 2297) / 5;

                Celcius.Text = Math.Round(cel, 2).ToString();
                Fahrenheit.Text = Math.Round(fah, 2).ToString();
                Kelvin.Text = Math.Round(kel, 2).ToString();
            }
        }

        private void Calcular_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (!(RbCelsius.Checked) && !(RbFahrenheit.Checked) && !(RbKelvin.Checked))
                {
                    MessageBox.Show("Selecione a Unidade de temperatura a ser convertida");
                }

                else if (TxtConverter.Text.Equals(""))
                {
                    MessageBox.Show("Digite a temperatura e ser convertida");
                }

                else if ((RbKelvin.Checked) && ((double.Parse(TxtConverter.Text)) < 0))
                {
                    MessageBox.Show("Não e possivel converter, pois não existe temperatura abaixo de 0 Absoluto");
                    TxtConverter.Clear();
                }

                else if ((RbCelsius.Checked) && ((double.Parse(TxtConverter.Text)) < -273))
                {
                    MessageBox.Show("Não e possivel converter, pois não existe temperatura abaixo de 0 Absoluto");
                    TxtConverter.Clear();
                }

                else if ((RbFahrenheit.Checked) && ((double.Parse(TxtConverter.Text)) < -459))
                {
                    MessageBox.Show("Não e possivel converter, pois não existe temperatura abaixo de 0 Absoluto");
                    TxtConverter.Clear();
                }

            }

            catch
            {
                MessageBox.Show("Preencha corretamente o campo");
                TxtConverter.Clear();
            }
        }
    }
}
