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
    public partial class Ataque : Form
    {
        //variavel para acessar a classes
        DadosAviao aviao;
        Giro rotacao;

        //variavel para armazenar a data e hora do ataque
        string data;

        //variavel para armazenar o usuario do ataque
        string usuario;

        //variavel para alocar a imagem do aviao
        Image foto = Image.FromFile(Environment.CurrentDirectory + "\\Imagens\\drone.png");

        //variaveis para o timer e angulo do picturebox do aviao
        int bx, by, m=0, cont=0, ax = 580, ay = 522, c, d, razao, r;
        float angulo;

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //verifica se foi digitado algum nome de missão
            if(textBox1.Text == "")
            {
                MessageBox.Show("Favor preencher o nome da missão");
            }

            //verifica se exite alguma missao com o mesmo nome digitado
            using (StreamReader a = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt"))
            {
                string linha;
                string[] dados;
                while ((linha = a.ReadLine()) != null)
                {
                    dados = linha.Split('#');
                    if (textBox1.Text.Equals(dados[0]))
                        {
                            MessageBox.Show("Nome de missão ja existente");
                            textBox1.Text = "";
                            break;
                        }
                    }
                }

        }
             
        private void bomba_Tick(object sender, EventArgs e)
        {
            if(cont == 6 && m == 1)
            {
                // parar o timer (bomba)
                bomba.Stop();

                //esconde o picturebox(explosao)
                explosao.Visible = false;

                //volta o picturebox(drone)
                drone.Visible = true;

                //inicia o timer(volta do aviao)
                volta.Start();
            }

            else if (cont == 6 && m == 2) 
            {
                // para o timer (bomba)
                bomba.Stop();

                //esconde o picturebox(explosao)
                explosao.Visible = false;
                
                //para poder chamar a tela de ultimo relatorio
                Form re = new RelatorioUlt();
                re.Show();

                //fecha a tela de ataque
                this.Close();
            }

            else
            {
                // incrementa 1 segundo
                cont++;
            }
        }

        private void volta_Tick(object sender, EventArgs e)
        {
            //rotação da imagem do aviao(drone)
            if (r==1)
            {
                drone.Image = rotacao.rotacao(foto, -angulo+180);
            }
            else if (r==2)
            {
                drone.Image = rotacao.rotacao(foto, angulo);
            }
            else if (r==3)
            {
                drone.Image = rotacao.rotacao(foto, -angulo);
            }
            else if(r==4)
            {
               drone.Image = rotacao.rotacao(foto,-180+ angulo);
            }

            // Calculos referentes a volta do drone pelo 3 quadrante
            if (bx < 580 && 522 < by)
            {
                c = 580 - bx;
                d = by - 522;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    bx += razao;
                    by--;
                }
                else
                {
                    bx++; ;
                    by -= razao;
                }
            }

            // Calculos referentes a volta do drone pelo 1 quadrante
            else if (580 < bx && 522 > by)
            {
                c = bx - 580;
                d = 522 - by;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    bx -= razao;
                    by++;
                }
                else
                {
                    bx--; ;
                    by += razao;
                }
            }

            // Calculos referentes a volta do drone pelo 4 quadrante
            else if (580 < bx && 522 < by)
            {
                c = bx - 580;
                d = by - 522;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    bx -= razao;
                    by--;
                }
                else
                {
                    bx--; ;
                    by -= razao;
                }
            }

            // Calculos referentes a volta do drone pelo 2 quadrante
            else if (bx < 580 && 522 > by)
            {
                c = 580 - bx;
                d = 522 - by;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    bx += razao;
                    by++;
                }
                else
                {
                    bx++; ;
                    by += razao;
                }
            }

            // picturebox(drone) recebe a nova posiçao a cada calculo feito
            drone.Location = new Point(-30 + bx, -30 + by);

            if (580 == bx && 522 == by)
            {
                //termina a execução do timer(volta do aviao)
                volta.Stop();

                // chamar a tela de ultimo relatorio
                Form a = new RelatorioUlt();
                a.Show();

                // fecha a tela de ataque
                this.Close();
            }
        }

        public Ataque()
        {            
            InitializeComponent();
            //variavel para acessar as funções da classe
            aviao = new DadosAviao();
            rotacao = new Giro();

            //mascara o groupBox
            groupBox1.BackColor = Color.FromArgb(80, Color.BlanchedAlmond);

            //percorre o arquivo de acesso e salva o usuario em uma varivel
            // lê o arquivo e distribui para os campos determinados.
            using (StreamReader op = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\acesso.txt"))
            {
                string line;
                string[] d;
                while ((line = op.ReadLine()) != null)
                {
                    d = line.Split('#');
                    usuario = d[0];
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama a tela principal
            Form a = new Principal();
            a.Show();

            //fecha a tela de ataque
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variaveis locais
            double cx = 580, cy = 522, dx = double.Parse(label4.Text), dy = double.Parse(label5.Text), dis, rx, ry, ang, res; ;
            cx = Math.Pow((cx * 9.33), 2); cy = Math.Pow((cy * 16.59), 2);
            dx = Math.Pow((dx * 9.33), 2); dy = Math.Pow((dy * 16.59), 2);
            rx = double.Parse(label4.Text); ry = double.Parse(label5.Text);

            if (dx > cx)
            {
                if (cy > dy)
                {
                    // dis -  calculo da distancia entre a base e o ataque
                    dis = Math.Sqrt((dx - cx) + (cy - dy));

                    //calculo para rotacionar o picturebox em um angulo especificado pelo ataque
                    ang = ((ay - ry) / (rx - ax));
                    res = (Math.Atan(ang) * (180 / Math.PI));

                    //converte res para float
                    angulo = (float)res;

                    //função para rotacionar a imagem 
                    drone.Image = rotacao.rotacao(foto, - angulo);

                    //variavel para localizar o quadrante
                    r = 1;
                    
                }
                else
                {
                    dis = Math.Sqrt((dx - cx) + (dy - cy));
                    ang = ((ry - ay) / (rx - ax));
                    res = (Math.Atan(ang) * (180 / Math.PI));
                    angulo = (float)res;
                    drone.Image = rotacao.rotacao(foto, angulo);
                    r = 4;
                }
            }
            else
            {
                if (cy > dy)
                {
                    dis = Math.Sqrt((cx - dx) + (cy - dy));
                    ang = ((ay - ry) / (ax - rx));
                    res = (Math.Atan(ang) * (180 / Math.PI));
                    angulo = (float)res;
                    drone.Image = rotacao.rotacao(foto, -180+angulo);
                    r = 2;
                }
                else
                {
                    dis = Math.Sqrt((cx - dx) + (dy - cy));
                    ang = ((ry - ay) / (ax - rx));
                    res = (Math.Atan(ang) * (180 / Math.PI));
                    angulo = (float)res;
                    drone.Image = rotacao.rotacao(foto, -angulo+180);
                    r = 3;
                }
            }
            
            // limite de voo do drone 11500 km
            if (dis < 11500)
            {
                //condições do ataque do aviao
                Random rdm = new Random();
                int id = rdm.Next(0, 30);
                drone.Visible = true;

                // Missao cumprida
                if (id <= 4 || id >= 26 || id >= 16 && id <= 19)
                {
                    //variavel para a condição do timer(ida do drone)
                    m = 1;

                    //inicia o timer(ida do drone)
                    ida.Start();
                    aviao.ataque1(textBox1.Text, label4.Text, label5.Text, dis, data, usuario);
                }

                //Missao cumprida, mas perde o aviao
                else if(id >= 6 && id <=9 )
                {
                    //variavel para a condição do timer(ida do drone)
                    m = 2;

                    //inicia o timer(ida do drone)
                    ida.Start();

                    //entrega os dados necessarios para a função
                    aviao.ataque2(textBox1.Text, label4.Text, label5.Text, dis, data, usuario);
                }

                //Missao abortada
                else if (id >= 11 && id <= 14 || id >= 21 && id <= 24)
                {
                    //variavel para a condição do timer(ida do drone)
                    m = 3;

                    //inicia o timer(ida do drone)
                    ida.Start();

                    //entrega os dados necessarios para a função
                    aviao.ataque3(textBox1.Text, label4.Text, label5.Text, dis, data, usuario);
                }

                //Missao falhou
                else
                {
                    //variavel para a condição do timer(ida do drone)
                    m = 4;

                    //inicia o timer(ida do drone)
                    ida.Start();

                    //entrega os dados necessarios para a função
                    aviao.ataque4(textBox1.Text, label4.Text, label5.Text, dis, data, usuario);
                }

                pictureBox1.Enabled = false;    //bloqueia a tela do mapa para nao clicar e causar algun erro  
            }

            //else do limite do aviao
            else
            {
                MessageBox.Show("Fora dos limites de ataque");
            }

            //executa quando clica no botao
            textBox1.Text = "";             //apaga o que esta escrito no campo de missao
            groupBox1.Visible = false;      //esconde na tela o groupbox de comandos
            pictureBox1.Refresh();          //atualiza o mapa para retirar a linha escrita
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //criar um ponto no mapa, no caso e a nossa base
            Point a = new Point();
            a.X = 580; a.Y = 522;

            //selecionar no mapa um ponto, no caso onde vai ser enviado o ataque
            Point b = new Point();
            b.X = MousePosition.X;
            b.Y = MousePosition.Y;

            //traça uma linha da base ate o ponto selecionado
            Graphics p = pictureBox1.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p.DrawLine(new Pen(Color.CornflowerBlue, 2), a, b);
            
            string message = "Deseja mandar o ataque ao local definido?";  //mensangem exibida dentro do messagebox
            string caption = "Longitude - " + b.X + " Latitude - " + b.Y;  //mensagem exibida na parte superior do messagebox
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;           //uma varialvel e seleciona quais botões vai aparecer no messagebox
            DialogResult result;                                           //variavel q armazena o resulado do clique do botao selecionado no messagebox
            result = MessageBox.Show(message, caption, buttons);

            //Se caso clicar no SIM no messegebox
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                pictureBox1.Enabled = false;
                groupBox1.Visible = true;       
                label4.Text = b.X.ToString();   
                label5.Text = b.Y.ToString();

                //determina a data e hora do ataque
                label7.Text = DateTime.Now.ToString();

                //armazena a data e hora para entregar nas funçoes
                data = label7.Text;

                //armazena o valor do ponto seleciona para se utilizado no calculos dos timers
                bx = int.Parse(label4.Text);    
                by = int.Parse(label5.Text);
            }

            else
            {
                //atualiza o picturebox(retirando a linha desenhada)
                pictureBox1.Refresh();
                pictureBox1.Enabled = true;
            }
        }

        private void ida_Tick(object sender, EventArgs e)
        {
            // Calculos referentes a ida do drone pelo 1 quadrante
            if (bx > ax && ay > by)
            {
                c = bx - ax;
                d = ay - by;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    ax += razao;
                    ay--;
                }
                else
                {
                    ax++; ;
                    ay -= razao;
                }                                
            }
                
            // Calculos referentes a ida do drone pelo 4 quadrante
            else if (bx > ax && ay < by)
            {
                c = bx - ax;
                d = by - ay;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    ax += razao;
                    ay++;
                }
                else
                {
                    ax++; ;
                    ay += razao;
                }
            }

            // Calculos referentes a ida do drone pelo 2 quadrante
            else if (ax > bx && ay > by)
            {
                c = ax - bx;
                d = ay - by;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    ax -= razao;
                    ay--;
                }
                else
                {
                    ax--; ;
                    ay -= razao;
                }
            }

            // Calculos referentes a ida do drone pelo 3 quadrante
            else if (ax > bx && ay < by)
            {
                c = ax - bx;
                d = by - ay;

                if (c < d)
                    razao = d / c;
                else
                    razao = c / d;


                if (c > d)
                {
                    ax -= razao;
                    ay++;
                }
                else
                {
                    ax--; ;
                    ay += razao;
                }
            }

            // picturebox(drone) recebe a nova posiçao a cada calculo feito
            drone.Location = new Point(-30+ax, -30+ay);

            //quando o picturebox(drone) alcança a posiçao desejada
            if (ax == bx && ay == by)
            {
                //para a timer(ida do drone)
                ida.Stop();

                //picturebox(explosao) recebe a posicao do ataque
                explosao.Location = new Point(-30 + bx, -30 + by);

                if (m==1)
                {
                    drone.Visible = false;

                    //picturebox da bomba aparece
                    explosao.Visible = true;
                    //inicia o timer(bomba - simulando a explosao)
                    bomba.Start();
                }

                if (m == 2)
                {
                    //mesma coisas do caso acima
                    drone.Visible = false;
                    explosao.Visible = true;
                    bomba.Start();
                }

                if (m == 3)
                {
                    //inicia o timer(volta do drone)
                    volta.Start();
                }

                if (m == 4)
                {                    
                    drone.Visible = false;

                    // chama a tela de ultimo relatorio
                    Form a = new RelatorioUlt();
                    a.Show();

                    //fecha a tela de ataque
                    this.Close();
                }
                
            }
        }
    }
}
