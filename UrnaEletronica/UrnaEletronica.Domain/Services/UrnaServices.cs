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
        private CandidatoDao _candidatoDao;
        public Candidato BuscarCandidato(string numero)
        {
            int numeroCandidato = int.Parse(numero);
            Candidato candidato = CandidatoDao.ListaDeCandidatos.Where(u => u.Nome == numero).First();
            return candidato;
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
        public void AddVoto(Voto voto)
        {
            VotoDao.ListaDeVotoEleito.Add(voto);
        }
    }
}
