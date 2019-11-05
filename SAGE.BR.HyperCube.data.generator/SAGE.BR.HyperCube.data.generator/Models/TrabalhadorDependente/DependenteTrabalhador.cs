using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class DependenteTrabalhador
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string idTipoDependente { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string cpf { get; set; }
        public bool dependenteIRRF { get; set; }
        public bool possuiIncapacidade { get; set; }
        public string dataMaximaIncidenciaIRRF { get; set; }
    }
}
