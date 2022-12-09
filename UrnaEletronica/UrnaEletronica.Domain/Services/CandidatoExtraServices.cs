using System;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;
using System.Collections.Generic;

namespace UrnaEletronica.Domain.Services
{
	public class CandidatoExtraServices
	{	
		static CandidatosDao _candidatosDAO = new CandidatosDao();
		public void AdicionarVisitanteNaLista(Candidato CandidatoASerCadastrado)
		{
			CandidatoASerCadastrado.DataDeCriacao = DateTime.Now;
			CandidatosDao.ListaDeCandidatos.Add(CandidatoASerCadastrado);
			
		}
		public void ListarCandidatos()
		{
			
			
		}
		
	}
}
