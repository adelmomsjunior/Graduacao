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
    public partial class Estatisticasmapa : Form
    {
        public Estatisticasmapa()
        {
            InitializeComponent();
        }

        private void Estatisticasmapa_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void rdgeral_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = op.ReadLine()) != null)
                {
                    dados = linha.Split('#');


                    //criar um ponto no mapa, no caso e a nossa base
                    Point a = new Point();
                    a.X = 580; a.Y = 522;

                    //traça uma linha da base ate o ponto selecionado
                    Graphics p = pictureBox1.CreateGraphics();
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;



                    if (dados[1] == "Cumprida")
                    {


                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.LimeGreen, 1), a, b);
                    }
                    if (dados[1] == "Abortada")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Blue,1), a, b);
                    }
                    if (dados[1] == "Falha")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Red,1), a, b);
                    }
                    if (dados[1] == "Cumprida com perdas")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Gold,1), a, b);
                    }
                }
            }
        
    }

        private void rdcump_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = op.ReadLine()) != null)
                {
                    dados = linha.Split('#');


                    //criar um ponto no mapa, no caso e a nossa base
                    Point a = new Point();
                    a.X = 580; a.Y = 522;

                    //traça uma linha da base ate o ponto selecionado
                    Graphics p = pictureBox1.CreateGraphics();
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;



                    if (dados[1] == "Cumprida")
                    {

                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.LimeGreen, 1), a, b);
                    }
                }
            }
        }

        private void rdcumperdas_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = op.ReadLine()) != null)
                {
                    dados = linha.Split('#');


                    //criar um ponto no mapa, no caso e a nossa base
                    Point a = new Point();
                    a.X = 580; a.Y = 522;

                    //traça uma linha da base ate o ponto selecionado
                    Graphics p = pictureBox1.CreateGraphics();
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (dados[1] == "Cumprida com perdas")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Gold), a, b);
                    }

                }
            }
        }

        private void rdabort_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = op.ReadLine()) != null)
                {
                    dados = linha.Split('#');


                    //criar um ponto no mapa, no caso e a nossa base
                    Point a = new Point();
                    a.X = 580; a.Y = 522;

                    //traça uma linha da base ate o ponto selecionado
                    Graphics p = pictureBox1.CreateGraphics();
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (dados[1] == "Abortada")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Blue), a, b);
                    }
                }
            }
        }

        private void rdfalha_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = op.ReadLine()) != null)
                {
                    dados = linha.Split('#');


                    //criar um ponto no mapa, no caso e a nossa base
                    Point a = new Point();
                    a.X = 580; a.Y = 522;

                    //traça uma linha da base ate o ponto selecionado
                    Graphics p = pictureBox1.CreateGraphics();
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (dados[1] == "Falha")
                    {
                        //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
                        Point b = new Point();
                        b.X = int.Parse(dados[2]);
                        b.Y = int.Parse(dados[3]);

                        p.DrawLine(new Pen(Color.Red), a, b);
                    }

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
