using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto
{
    class DadosTerro
    {
//---------------- FUNCAO salvar um novo terrorista
        public void salvarterrorista(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            using (StreamWriter j = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt", true))
            {
                j.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}", a, b, c, d, e, f, g, h, i);
                j.Close();
            }
        }
//---------------- FUNCAO modifica um terrorista cadastrado
        public void mod(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            //para alterar um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\terrorista1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');
                        //verificando se a linha atual é a linha desejada.
                        if (dados[0].Equals(a) == true)
                        {
                            //alterando os dados conforme desejado.
                            esc.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}", a, b, c, d, e, f, g, h, i);
                        }
                        else
                        {
                            //caso contrário, é feito uma cópia exata da linha que está no arquivo.
                            esc.WriteLine("{0}", linha);
                        }

                    }
                    ler.Close();
                }

            }
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\terrorista.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\terrorista1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);


        }
        
    }
}
