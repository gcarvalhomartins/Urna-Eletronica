using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class CandidatosFixosServices
    {
        static CandidatosDao _candidatosDao = new CandidatosDao();

        static CandidatoExtraServices _candidadoExtrasServices = new CandidatoExtraServices();

        public bool JaExisteCadastroCandidato(int id)
        {
            if (CandidatosDao.ListaDeCandidatos.Any(x => x.Id == id))
            {
                Candidato CandidatoASerCadastrado = CandidatosDao.ListaDeCandidatos.Where(item => item.Id == id).First();
                return CandidatosDao.ListaDeCandidatos.Contains(CandidatoASerCadastrado);
            }
            return false;
        }

    }
}
