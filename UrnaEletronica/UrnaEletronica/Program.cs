using System;
using System.Collections.Generic;
using UrnaEletronica.CLI;

namespace UrnaEletronica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respostaUsuario;
            bool pediuPraSair = false;

            do
            {

            Console.WriteLine("Olá sou sua Urna Eletronica =)");
            Console.WriteLine("A - Para Vizualizar os Candidatos ");
            Console.WriteLine("B - Para Votar Diretamente ");
            Console.WriteLine("C - Extras ");
           
            respostaUsuario= Console.ReadLine();
            
            switch(respostaUsuario.ToLower()) {
                case "a":
                    CandidatosFixos.MenuExibirCandidato();
                    break;
                case "b":
                    Console.WriteLine();
                    break;
                case "c":
                    MenuExtras.CadastrarVisitante();
                    break;
                default:
                    pediuPraSair= true;
                    break;
            }

            }while(!pediuPraSair);
        }
    }
}
