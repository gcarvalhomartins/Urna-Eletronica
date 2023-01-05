using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.API.Controllers
{
    [Route("api/Candidatos")]
    [ApiController]
    public class CandidatosController : ControllerBase
    {   
        private CandidatoExtraServices _candidatoExtraServices = new CandidatoExtraServices();
        
        [HttpPost]
        public ActionResult CadastrarCandidato([FromBody] Candidato candidato)
        {
           
            return Ok(candidato.Id);
        }

    }
}

