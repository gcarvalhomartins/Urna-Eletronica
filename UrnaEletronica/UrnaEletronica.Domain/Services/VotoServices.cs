using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class VotoServices
    {
        VotoDao _votoDao = new VotoDao();

        public void adicionandovoto(VotoEleitor voto)
        {
            _votoDao.AddVoto(voto);
        }
        public bool VerificandoCandidatoParaVoto(int numero)
        {
            if (CandidatosDao.ListaDeCandidatos.Any(x => x.Id == numero))
            {
                Candidato CandidatoASerCadastrado = CandidatosDao.ListaDeCandidatos.Where(item => item.Id == numero).First();
                return CandidatosDao.ListaDeCandidatos.Contains(CandidatoASerCadastrado);
            }
            return false;
        }
        public void LimitandoQuantidadeDeVotos(int quantidadeDeVotos)
        {

            for(quantidadeDeVotos = 0; quantidadeDeVotos <= 20 ; quantidadeDeVotos++)
            {
                
            }
        }
        public void ExibirCandidatoParaOVoto(CandidatosDao respostaDoUsuarioParaVotacao)
        {

            foreach (var candidatoASerBuscado in CandidatosDao.ListaDeCandidatos)
            {
                Console.WriteLine("Id do Candidato : " + candidatoASerBuscado.Id);
                Console.WriteLine("Nome do Candidato : " + candidatoASerBuscado.Nome);
                Console.WriteLine("Número do Candidato : " + candidatoASerBuscado.Numero);
                Console.WriteLine("Partido do Candiato :" + candidatoASerBuscado.Partido);
                Console.WriteLine("Cargo Disputado :" + candidatoASerBuscado.CargoDisputado);
            }
        }
    }
}
