using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class CandidatosFixosServices
    {
        static CandidatoExtraServices _candidadoExtrasServices = new CandidatoExtraServices();
        public static void AdicionarCandidatosFixos()
        {

            Candidato candidatos1 = new Candidato();
            candidatos1.Id = 2323;
            candidatos1.Nome = "José";
            candidatos1.Numero = 13;
            candidatos1.Partido = "PVV";
            candidatos1.CargoDisputado = "Presidencia";

            Candidato candidatos2 = new Candidato();
            candidatos2.Id = 4675;
            candidatos2.Nome = "Paulo";
            candidatos2.Numero = 13;
            candidatos2.Partido = "KDI";
            candidatos2.CargoDisputado = "Presidencia";

            Candidato candidatos3 = new Candidato();
            candidatos3.Id = 9090;
            candidatos3.Nome = "Marquinhos";
            candidatos3.Numero = 13;
            candidatos3.Partido = "KEJ";
            candidatos3.CargoDisputado = "Governador";

            Candidato candidatos4 = new Candidato();
            candidatos4.Id = 5648;
            candidatos4.Nome = "Yoham";
            candidatos4.Numero = 13;
            candidatos4.Partido = "SWE";
            candidatos4.CargoDisputado = "Governador";

            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos1);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos2);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos3);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos4);

        }
    }
}
