using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{

    public class DependenteTrabalhadorPeriodo
    {
        public string id { get; set; }
        public string idDependenteTrabalhador { get; set; }
        public DependenteTrabalhador dependenteTrabalhadorReference { get; set; }
        public string inicioPeriodo { get; set; }
        public string fimPeriodo { get; set; }
        public bool deduzIRRF { get; set; }
        public string idTipoDependente { get; set; }
        public TipoDependente tipoDependenteReference { get; set; }
        public bool possuiIncapacidade { get; set; }
    }
}
