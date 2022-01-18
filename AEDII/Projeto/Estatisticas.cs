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
    public partial class Estatisticas : Form
    {
        public Estatisticas()
        {
            InitializeComponent();
            groupregiao.Visible = false;
            cmbestregioes.Visible = false;
            
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0, t = 0;
            float pera, perb, perc, perd;
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] v;
                while ((linha = op.ReadLine()) != null)
                {
                    v = linha.Split('#');
                    t++;
                    if ((v[1]) == "Cumprida")
                    {
                        a++;
                    }
                    if ((v[1]) == "Cumprida com perdas")
                    {
                        b++;
                    }
                    if ((v[1]) == "Abortada")
                    {
                        c++;
                    }
                    if ((v[1]) == "Falha")
                    {
                        d++;
                    }
                }
                pera = (100 * a) / t;
                perb = (100 * b) / t;
                perc = (100 * c) / t;
                perd = (100 * d) / t;

            }
            label2.Text = t.ToString() + " ataques";
            label4.Text = pera.ToString() + "%";
            label5.Text = perb.ToString() + "%";
            label6.Text = perc.ToString() + "%";
            label7.Text = perd.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama a tela principal 
            Form a = new Principal();
            a.Show();

            //fecha a tela 
            this.Close();
        }

        private void cmbestregioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // declarei os pontos da base
            double ax = 580, ay = 522;
            //declarei os contadores
            int cont = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0;
            double bx, by;
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] v;
                if (cmbestregioes.SelectedItem.Equals("Nordeste"))
                {
                    while ((linha = op.ReadLine()) != null)
                    {
                        //contando quantas vezes entrou
                        
                        v = linha.Split('#');
                        //declarei e to tentando passar pra double, o valor das coordenadas em x e em y de onde foi o ataque;

                        bx = double.Parse(v[2]);
                        by = double.Parse(v[3]);
                        //comparando oq ta selecionado

                        //comparando se ta no primeiro quadrante
                        if (bx > ax && by < ay)
                        {
                            cont++;
                            if (v[1].Equals("Cumprida"))
                            {
                                cont1++;
                            }
                            else if (v[1].Equals("Cumprida com perdas"))
                            {
                                cont2++;
                            }
                            else if (v[1].Equals("Abortada"))
                            {
                                cont3++;
                            }
                            else if (v[1].Equals("Falha"))
                            {
                                cont4++;
                            }
                        }

                    }
                    label14.Text = cont.ToString() + " ataques";
                    label23.Text = cont1.ToString() + " ataques";
                    label22.Text = cont2.ToString() + " ataques";
                    label21.Text = cont3.ToString() + " ataques";
                    label20.Text = cont4.ToString() + " ataques";
                    label25.Text = "Nordeste";
                    groupregiao.Visible = true;
                }

            
                else if (cmbestregioes.SelectedItem.Equals("Sudeste"))
            {
                while ((linha = op.ReadLine()) != null)
                {
                    //contando quantas vezes entrou
                    
                    v = linha.Split('#');
                    //declarei e to tentando passar pra double, o valor das coordenadas em x e em y de onde foi o ataque;

                    bx = double.Parse(v[2]);
                    by = double.Parse(v[3]);
                    //comparando oq ta selecionado

                    //comparando se ta no primeiro quadrante
                    if (bx > ax && by > ay)
                    {
                            cont++;
                            if (v[1].Equals("Cumprida"))
                        {
                            cont1++;
                        }
                        else if (v[1].Equals("Cumprida com perdas"))
                        {
                            cont2++;
                        }
                        else if (v[1].Equals("Abortada"))
                        {
                            cont3++;
                        }
                        else if (v[1].Equals("Falha"))
                        {
                            cont4++;
                        }
                    }

                }
                    label14.Text = cont.ToString() + " ataques";
                    label23.Text = cont1.ToString() + " ataques";
                    label22.Text = cont2.ToString() + " ataques";
                    label21.Text = cont3.ToString() + " ataques";
                    label20.Text = cont4.ToString() + " ataques";
                    label25.Text = cmbestregioes.SelectedItem.ToString();
                    groupregiao.Visible = true;
                }
                else if (cmbestregioes.SelectedItem.Equals("Noroeste"))
                {
                    while ((linha = op.ReadLine()) != null)
                    {
                        //contando quantas vezes entrou

                        v = linha.Split('#');
                        //declarei e to tentando passar pra double, o valor das coordenadas em x e em y de onde foi o ataque;

                        bx = double.Parse(v[2]);
                        by = double.Parse(v[3]);
                        //comparando oq ta selecionado

                        //comparando se ta no primeiro quadrante
                        if (bx < ax && by < ay)
                        {
                            cont++;
                            if (v[1].Equals("Cumprida"))
                            {
                                cont1++;
                            }
                            else if (v[1].Equals("Cumprida com perdas"))
                            {
                                cont2++;
                            }
                            else if (v[1].Equals("Abortada"))
                            {
                                cont3++;
                            }
                            else if (v[1].Equals("Falha"))
                            {
                                cont4++;
                            }
                        }

                    }
                    label14.Text = cont.ToString() + " ataques";
                    label23.Text = cont1.ToString() + " ataques";
                    label22.Text = cont2.ToString() + " ataques";
                    label21.Text = cont3.ToString() + " ataques";
                    label20.Text = cont4.ToString() + " ataques";
                    label25.Text = cmbestregioes.SelectedItem.ToString();
                    groupregiao.Visible = true;
                }
                else if (cmbestregioes.SelectedItem.Equals("Sudoeste"))
                {
                    while ((linha = op.ReadLine()) != null)
                    {
                        //contando quantas vezes entrou

                        v = linha.Split('#');
                        //declarei e to tentando passar pra double, o valor das coordenadas em x e em y de onde foi o ataque;

                        bx = double.Parse(v[2]);
                        by = double.Parse(v[3]);
                        //comparando oq ta selecionado

                        
                        if (bx < ax && by > ay)
                        {
                            cont++;
                            if (v[1].Equals("Cumprida"))
                            {
                                cont1++;
                            }
                            else if (v[1].Equals("Cumprida com perdas"))
                            {
                                cont2++;
                            }
                            else if (v[1].Equals("Abortada"))
                            {
                                cont3++;
                            }
                            else if (v[1].Equals("Falha"))
                            {
                                cont4++;
                            }
                        }

                    }
                    label14.Text = cont.ToString()+ " ataques";
                    label23.Text = cont1.ToString() + " ataques";
                    label22.Text = cont2.ToString() + " ataques";
                    label21.Text = cont3.ToString() + " ataques";
                    label20.Text = cont4.ToString() + " ataques";
                    label25.Text = cmbestregioes.SelectedItem.ToString();
                    groupregiao.Visible = true;
                }
            }


    }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbestregioes.Visible = true;
            
        }

        private void btestmapa_Click(object sender, EventArgs e)
        {
            Form mapa = new Estatisticasmapa();
            mapa.Show();
        }
    }
        }
