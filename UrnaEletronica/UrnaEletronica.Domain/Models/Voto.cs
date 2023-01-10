using System;
using System.Collections.Generic;
using System.Text;

namespace UrnaEletronica.Domain.Models
{
    public class Voto
    {
        public int VotoValido { get; set; }
        public int VotoEmBranco { get; set; }
        public int VoloNulo { get; set; }

        
    }
    
}
