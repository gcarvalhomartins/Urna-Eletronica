using System;

namespace UrnaEletronica.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool pediuPraSair= false;

            do
            {

            Console.WriteLine("Ola sou sua urna Eletronica =) ");
            Console.WriteLine("Digite o que deseja Realizar ");
            Console.WriteLine("A - PARA VIZUALIZAR CANDIDATOS ");
            Console.WriteLine("B - PARA VOTAR DIRETAMENTE ");
            
            string respostaUsuario= Console.ReadLine();
            switch(respostaUsuario.ToLower())
                {
                    case "a":
                        Console.WriteLine();
                        break;
                    case "b":
                        MenuVoto.BuscarCandidatoParaVoto();
                        break;
                    default:
                        pediuPraSair = true;
                        break;
                }
            }while(!pediuPraSair);
        }
    }
}
