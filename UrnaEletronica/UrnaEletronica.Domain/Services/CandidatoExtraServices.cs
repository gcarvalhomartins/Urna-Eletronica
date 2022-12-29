﻿using System;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;
using System.Collections.Generic;

namespace UrnaEletronica.Domain.Services
{
	public class CandidatoExtraServices
	{	
		static CandidatosDao _candidatosDAO = new CandidatosDao();
		public void AdicionarCandidatoNaLista(Candidato candidatoASerCadastrado)
		{
			candidatoASerCadastrado.DataDeCriacao = DateTime.Now;
			_candidatosDAO.AddCandidato(candidatoASerCadastrado);
		}
		
	}
}
