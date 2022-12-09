using System.Collections.Generic;
using System;

namespace UrnaEletronica.Domain.Models
{
	public class Candidato
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Numero { get; set; }
		public string CargoDisputado { get; set; }
		public string Partido { get; set; }
		public DateTime DataDeCriacao { get; set; }
	}
}