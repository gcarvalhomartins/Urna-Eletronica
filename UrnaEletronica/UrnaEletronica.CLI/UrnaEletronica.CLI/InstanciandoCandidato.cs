using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.CLI
{
    public class InstanciandoCandidato
    {
        public void CandidatosFixos()
        {
            Candidato candidato1 = new Candidato();
            candidato1.Nome = "José";
            candidato1.Numero = 10;
            candidato1.CargoDisputado = "Presidencia";
            candidato1.Partido = "PVV";

            Candidato candidato2 = new Candidato();
            candidato2.Nome = "Maria";
            candidato2.Numero = 20;
            candidato2.CargoDisputado = "Presidencia";
            candidato2.Partido = "CVV";

        }
    }
}
