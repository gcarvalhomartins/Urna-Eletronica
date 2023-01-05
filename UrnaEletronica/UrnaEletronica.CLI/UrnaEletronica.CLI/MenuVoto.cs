using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.CLI
{
    public class MenuVoto
    {   
        private static UrnaServices _urnaService = new UrnaServices();
        public static void IniciarVoto()
        {
            Console.WriteLine("Você esta em Modo votação Direta");
            Console.WriteLine("Digite o Número do Candidato");
            string repostaUsuario = Console.ReadLine();

            ExibirCandidato(repostaUsuario);
        }
        public static void ExibirCandidato(string candidato)
        {
            _urnaService.BuscarCandidato(candidato);
            Console.WriteLine(candidato);
        }
    }
}
