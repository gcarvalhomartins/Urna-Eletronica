using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.Services
{
    public class VotoService
    {
        private UrnaDAO _urnaDao;

        public bool VotoNulo(Voto voto)
        {
            while(voto != null)
            {
                _urnaDao.AddVoto(voto);
                return true;
            }
            return false;
        }
        public bool VotoEmBranco(Voto voto)
        {
            while (voto != null)
            {
                _urnaDao.AddVoto(voto);
                return true;
            }
            return false;
        }
        public bool VotoValido(Voto voto)
        {
            while (voto != null)
            {
                _urnaDao.AddVoto(voto);
                return true;
            }
            return false;
        }

    }
}
