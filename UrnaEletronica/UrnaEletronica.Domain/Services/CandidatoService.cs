using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class CandidatoService
    {
        private UrnaDAO _UrnaDAO;

        public bool ValidarSeCandidatoExiste(Candidato candidato)
        {
            return true;
        }
        public void CandidatosFixosAdd(Candidato candidato)
        {
            _UrnaDAO.AddCandidato(candidato);
        }

    }
}
