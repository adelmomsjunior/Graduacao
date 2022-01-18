using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto
{
    class DadosAviao
    {
//---------------- FUNCAO salvar relatorio
        public void salvarrelatorio(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string l, string m, string n)
        {
            using (StreamWriter k = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\relatorio.txt",true))
            {
                k.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}#{12}", a, b, c, d, e, f, g, h, i, j, l, m, n);
                k.Close();
            }
        }

//---------------- FUNCAO salvar o ultimo ataque
        public void ultimo(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string l, string m)
        {
            using (StreamWriter k = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\ultimorelatorio.txt"))
            {
                k.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}", a, b, c, d, e, f, g, h, i, j, l,m);
                k.Close();
            }
        }
       
//       FUNCAO avarias do aviao
        public string avarias(string a)
        {
            Random rdm = new Random();
            int b = rdm.Next(0,6);
            if (b == 0)
            {
                a = "Avaria na asa direita. ";
            }

            else if (b == 1)
            {
                a = "Falha na comunicação com a torre de Controle";
            }

            else if (b == 3)
            {
                a = "Falha no radar térmico. ";
            }

            else if (b == 4)
            {
                a = "Avaria no sensor de defesa. ";
            }

            else if (b == 5)
            {
                a = "Avaria na asa esquerda. ";
            }
            else 
            {
                a = "Eventos climaticos, alterando as comunicações. ";
            }
            return (a);
        }

//INICIO---------- Funcões do ataque do aviao

        //feito para utilizar apenas uma variavel para random
        Random rdm = new Random();

        //variaveis do processo de ataque
        double vento, velfinal, tempo, consumo, distancia;
        int bomba, missil, bala;
        string objetivo, observacao = "";

        public void ataque1(string missao, string corx, string cory, double dis, string data, string usuario)
        {
            //multiplica a distancia por dois -  ida e volta
            distancia = dis * 2;

            //rodar aleatorio para vento
            vento = rdm.Next(0, 20);

            //transforma o vento em porcentagem
            vento /= 100;

            //velocidade final
            velfinal = 2000 - (2000 * vento);

            //tempo de voo
            tempo = distancia / velfinal;

            //comsumo do aviao
            consumo = (distancia / (10 - (10 * vento)));

            //aleatorio para munição
            bomba = rdm.Next(0, 3);
            missil = rdm.Next(0, 10);
            bala = rdm.Next(0, 2500);

            // detalhe da missao
            objetivo = "Cumprida";
            observacao = "Drone apto para a proxima missão";

            //salvar os dados do aviao
            salvarrelatorio(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data, usuario);
            ultimo(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data);

        }

        public void ataque2(string missao, string corx, string cory, double dis, string data, string usuario)
        {            
            //rodar aleatorio para vento
            vento = rdm.Next(0, 20);

            //transforma o vento em porcentagem
            vento /= 100;

            //velocidade final
            velfinal = 2000 - (2000 * vento);

            //tempo de voo
            tempo = dis / velfinal;

            //comsumo do aviao
            consumo = 3000;

            //aleatorio para munição
            bomba = 3;
            missil = 10;
            bala = 2500;

            // detalhe da missao
            objetivo = "Cumprida com perdas";
            observacao = "Drone Abatido";

            //salvar os dados do aviao
            salvarrelatorio(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data, usuario);
            ultimo(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data);
        }

        public void ataque3(string missao, string corx, string cory, double dis, string data, string usuario)
        {
            //multiplica a distancia por dois -  ida e volta
            distancia = dis * 2;

            //rodar aleatorio para vento
            vento = rdm.Next(0, 20);

            //transforma o vento em porcentagem
            vento /= 100;

            //velocidade final
            velfinal = 2000 - (2000 * vento);

            //tempo de voo
            tempo = distancia / velfinal;

            //comsumo do aviao
            consumo = (distancia / (10 - (10 * vento)));

            //aleatorio para munição
            bomba = 0;
            missil = 0;
            bala = 0;

            // detalhe da missao
            objetivo = "Abortada";
            observacao = avarias(observacao) + " \tDrone enviado para manutenção";

            //salvar os dados do aviao
            salvarrelatorio(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data, usuario);
            ultimo(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data);

        }

        public void ataque4(string missao, string corx, string cory, double dis, string data, string usuario)
        {
            //rodar aleatorio para vento
            vento = rdm.Next(0, 20);

            //transforma o vento em porcentagem
            vento /= 100;

            //velocidade final
            velfinal = 2000 - (2000 * vento);

            //tempo de voo
            tempo = dis / velfinal;

            //comsumo do aviao
            consumo = 3000;

            //aleatorio para munição
            bomba = 3;
            missil = 10;
            bala = 2500;

            // detalhe da missao
            objetivo = "Falha";
            observacao = " Drone Abatido";

            //salvar os dados do aviao
            salvarrelatorio(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data, usuario);
            ultimo(missao, objetivo, corx, cory, Math.Ceiling(dis).ToString(), Math.Ceiling(tempo).ToString(), Math.Ceiling(consumo).ToString(), bomba.ToString(), missil.ToString(), bala.ToString(), observacao, data);

        }

//FIM-------------  
    }
}
