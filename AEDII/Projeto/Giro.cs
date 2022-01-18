using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projeto
{
    class Giro
    {
        public Bitmap rotacao(Image foto, float angulo)
        {
            //Largura, Altura
            int W, H;

            Bitmap bmpOriginal = new Bitmap(foto);

            //Pega os pontos centrais da imagem para serem
            //a origem da rotacao
            float pontoRotacaoX = bmpOriginal.Width / 2;
            float pontoRotacaoY = bmpOriginal.Height / 2;
                              
                W = bmpOriginal.Width;
                H = bmpOriginal.Height;
                
            //Cria uma cópia da imagem original para fazer a rotação
            Bitmap bmpRotacionado = new Bitmap(W, H);
            //Mantêm a resolução original
            bmpRotacionado.SetResolution(bmpOriginal.HorizontalResolution, bmpOriginal.VerticalResolution);

            //Cria um novo "gráfico" com a imagem rotacionada
            Graphics g = Graphics.FromImage(bmpRotacionado);

            //Centraliza o ponto de rotação
            g.TranslateTransform(pontoRotacaoX, pontoRotacaoY);

            //Finalmente a rotação :-)
            g.RotateTransform(angulo);

            //Reposiona a imagem
            g.TranslateTransform(-pontoRotacaoX, -pontoRotacaoY);

            //Desenha a imagem rotacionada
            g.DrawImage(bmpOriginal, new PointF(0, 0));
            
            return (bmpRotacionado);
        }
    }
}
