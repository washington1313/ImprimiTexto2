using System;

namespace ImprimirTexto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFInal;

            Console.WriteLine("Digite seu nome: ");
            string nomeEntrada = Console.ReadLine();
            Console.Clear();

            nomeFInal = ImprimindoMenuFinal(nomeEntrada);
            Console.WriteLine(nomeFInal);

            Console.ReadKey();
        }

        static string ImprimindoMenuFinal (string nome)
        {
            string texto = "########## MENU ############\n" +
                                       nome + "\n" + 
                          "############################";


            return texto;
        }

    }
}
