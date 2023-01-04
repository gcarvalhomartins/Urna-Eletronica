using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.CLI
{
    public class MenuVotacao
    {
        static CandidatoExtraServices _candidatoExtraService = new CandidatoExtraServices();
        static CandidatosFixosServices _candidatosFixosService = new CandidatosFixosServices();
        static VotoServices _votoService = new VotoServices();

        public static void Votacao(VotoEleitor respostaUsuarioParaVotacao)
        {
            Console.WriteLine("MODO VOTAÇÃO");
            Console.WriteLine("Digite o Número do Candidato");
            string repostaUsuarioParaVotacao = Console.ReadLine();

            _votoService.ExibirCandidatoParaOVoto(repostaUsuarioParaVotacao);


            int numeroCandidato = int.Parse(repostaUsuarioParaVotacao);


            VotoEleitor votoASerCadastrado = new VotoEleitor();
            votoASerCadastrado.Numero = numeroCandidato;

           
        }
        public static void VerificandoSeCandidatoExiste(Candidato candidatoASerVotado)
        {
            bool jaExiste = _candidatosFixosService.JaExisteCadastroCandidato(candidatoASerVotado.Numero);

        }
    }
}
