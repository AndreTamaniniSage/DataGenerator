using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.Cargo
{
    public class Cargo
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string idClassificacaoBrasileiraOcupacao { get; set; }
        public ClassificacaoBrasileiraOcupacao classificacaoBrasileiraOcupacaoReference { get; set; }
        public string status { get; set; }    
    }
    
}
