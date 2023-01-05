using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class UrnaServices
    {
        private static CandidatoDao _candidatoDao = new CandidatoDao();
        public List<Candidato> ListarCandidatos()
        {
            return CandidatoDao.ListaDeCandidatos.OrderBy(item => item.Nome).ToList();
        }
        public void AdicionarCandidato(Candidato candidato)
        {
            CandidatoDao.ListaDeCandidatos.Add(candidato);
        }
        public bool VerificarSeCandidatoExiste(int numero)
        {
            if (CandidatoDao.ListaDeCandidatos.Any(x => x.Numero == numero))
            {
                Candidato candidatoASerVerificado = CandidatoDao.ListaDeCandidatos.Where(item => item.Numero == numero).First();
                return CandidatoDao.ListaDeCandidatos.Contains(candidatoASerVerificado);
            }
            return false;
        }
        public Candidato ObterCandidado(int numero)
        {
            Candidato candidato = CandidatoDao.ListaDeCandidatos.Where(item => item.Numero == numero).First();
            return candidato;
        }
        public Candidato ObterCandidato(string nome)
        {
            Candidato candidato = CandidatoDao.ListaDeCandidatos.Where(item => item.Nome == nome).First();
            return candidato;
        }
        public void AddVoto(Eleitor voto)
        {   
            EleitorDAO.ListaDeVotoCotados.Add(voto);
        }
        public Eleitor CotarVoto(int votoASercotado)
        {
            Eleitor voto = EleitorDAO.ListaDeVotoCotados.Where(item => item.VotoCotado == votoASercotado).First();
            return voto;
        }
    
        
    }
}
