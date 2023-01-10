using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class EleitorService
    { 
        private UrnaDAO _urnaDAO;

        public bool ValidadorDeTitulo(Eleitor titulo)
        {
            while (titulo != null)
            {
                _urnaDAO.AddEleitor(titulo);
                return true;
            }
            return false;
        }
    }
}
