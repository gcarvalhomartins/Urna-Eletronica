using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.CLI
{
    public class MenuVoto
    {   
        private static UrnaServices _urnaService = new UrnaServices();
        public static void BuscarCandidatoParaVoto()
        {   
            Candidato candidatoTeset = new Candidato();
            candidatoTeset.Nome = "tESTE";
            candidatoTeset.Numero = 12;
            candidatoTeset.CargoDisputado = "Presidencia";
            candidatoTeset.Partido = "pv";
            _urnaService.AdicionarCandidato(candidatoTeset);


            Console.WriteLine("Você esta em Modo votação Direta");
            Console.WriteLine("Digite o Número do Candidato");
            string repostaUsuario = Console.ReadLine();

            int numeroDoCandidatoBuscado = int.Parse(repostaUsuario);

            Candidato candidatoRecebido = _urnaService.ObterCandidado(numeroDoCandidatoBuscado);
            ExibirCandidato(candidatoRecebido);

            Console.WriteLine("Confirmar Voto ?");
            Console.WriteLine("A - PARA CONFIRMAR");
            Console.WriteLine("B - PARA NÃO CONFIRMAR");
            Console.WriteLine("C - PARA VOTAR NULO");

            string confirmacaoDeVoto = Console.ReadLine();
            switch (confirmacaoDeVoto.ToLower())
            {
                case "a":
                    ConfirmarVoto();
                    break;
                case "b":
                    Console.WriteLine();
                    break;
                case "c":
                    Console.WriteLine();
                    break;

            }
        }
      
        public static void ExibirCandidato(Candidato candidato)
        {
            Console.WriteLine("Candidato:" + candidato.Nome);
            Console.WriteLine("Cargo Disputado :" + candidato.CargoDisputado);

        }
        static void ConfirmarVoto(Eleitor confirmarVoto)
        {
            Eleitor votoASerRealizado = new Eleitor();
            votoASerRealizado.VotoCotado = confirmarVoto.VotoCotado;
            _urnaService.AddVoto(votoASerRealizado);

            Console.WriteLine("Voto confirmado com sucesso");
        }

    }
}
