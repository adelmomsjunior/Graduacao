using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto
{
    class Dadosusu
    {
//---------------- FUNCAO salvar um usuario
        public void salvarusuario(string e, string b, string c)
        {
            using (StreamWriter a = new StreamWriter (Environment.CurrentDirectory + "\\BancoDados\\usuario.txt", true))
            {
                a.WriteLine("{0}#{1}#{2}", e, b, c);
                a.Close();
            }
        }

//---------------- FUNCAO salva um arquivo contento o usuario e senha utiliado para fazer o login no programa
        public void acesso(string q, string w, string e)
        {
            using (StreamWriter a = new StreamWriter (Environment.CurrentDirectory + "\\BancoDados\\acesso.txt"))
            {
                a.WriteLine("{0}#{1}#{2}", q, w, e);
                a.Close();
            }
        }

//---------------- FUNCAO para apagar uma linha do arquivo
        public void delusu(string comb)
        {
            //para alterar um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\usuario1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');
                        //verificando se a linha atual é a linha desejada.
                        if (dados[0].Equals(comb) == true)
                        {                            
                            //alterando os dados conforme desejado.
                            string mod = "";
                            esc.WriteLine("{0}#{1}#{2}", mod, mod, mod);
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
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\usuario.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\usuario1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);


        }

//---------------- FUNCAO para reescreve o arquivo todo pulando as linhas em branco deixada pela função anterior
        public void atualizausu()
        {
            //para reescrever um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\usuario1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\usuario.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');

                        //verificando se a linha atual e uma linha escrita em branco
                        if (!dados[0].Equals(""))
                        {                            
                           //caso contrário, é feito uma cópia exata da linha que está no arquivo.
                           esc.WriteLine("{0}", linha);
                        }

                    }
                    ler.Close();
                }

            }
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\usuario.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\usuario1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);


        }

//---------------- FUNCAO  para escrever no arquivo de historico quando faz o login no projeto
        public void entrada(string q, string w, string e)
        {
            using (StreamWriter a = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\historico.txt",true))
            {
                a.WriteLine("{0}#{1}#{2}", q, w, e);
                a.Close();
            }
        }
        
//---------------- FUNCAO para escrevar no arquivo de historico quando faz o logout no projeto
        public void saida(string a)
        {
            //para alterar um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\historico1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\historico.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');
                        //verificando se a linha atual é a linha desejada.
                        if (dados[2].Equals("Online") == true)
                        {
                            //alterando os dados conforme desejado.
                            esc.WriteLine("{0}#{1}#{2}", dados[0],dados[1],a);
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
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\historico.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\historico1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);
        }

//---------------- FUNCAO para apagar uma linha do arquivo
        public void delhis(string comb)
        {
            //para alterar um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\historico1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\historico.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');
                        //verificando se a linha atual é a linha desejada.
                        if (dados[0].Equals(comb) == true)
                        {
                            //alterando os dados conforme desejado.
                            string mod = "";
                            esc.WriteLine("{0}#{1}#{2}", mod, mod, mod);
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
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\historico.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\historico1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);


        }

//---------------- FUNCAO para reescreve o arquivo todo pulando as linhas em branco deixada pela função anterior
        public void atualizahis()
        {
            //para reescrever um arquivo é necessário criar um arquivo temporário no modo de escrita e o arquivo original em modo de leitura.
            using (StreamWriter esc = new StreamWriter(Environment.CurrentDirectory + "\\BancoDados\\historico1.txt"))
            {
                using (StreamReader ler = new StreamReader(Environment.CurrentDirectory + "\\BancoDados\\historico.txt"))
                {
                    string linha;
                    string[] dados;
                    while ((linha = ler.ReadLine()) != null)
                    {
                        dados = linha.Split('#');

                        //verificando se a linha atual e uma linha escrita em branco
                        if (!dados[0].Equals(""))
                        {
                            //caso contrário, é feito uma cópia exata da linha que está no arquivo.
                            esc.WriteLine("{0}", linha);
                        }

                    }
                    ler.Close();
                }

            }
            string a1 = Environment.CurrentDirectory + "\\BancoDados\\historico.txt";
            string a2 = Environment.CurrentDirectory + "\\BancoDados\\historico1.txt";
            //uma vez alterado, apaga-se o arquivo original
            System.IO.File.Delete(a1);
            //Cria uma cópia do arquivo temporário com o nome do arquivo orignal
            System.IO.File.Copy(a2, a1);
            //o arquivo temporário é apagado
            System.IO.File.Delete(a2);


        }

    }
}
