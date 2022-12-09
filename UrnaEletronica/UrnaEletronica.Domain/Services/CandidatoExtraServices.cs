using System;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
	public class CandidatoExtraServices
	{	
		public void AdicionarVisitanteNaLista(Candidato CandidatoASerCadastrado)
		{
			CandidatoASerCadastrado.DataDeCriacao = DateTime.Now;
			CandidatosDao.ListaDeCandidatos.Add(CandidatoASerCadastrado);
		}
		
	}
}
