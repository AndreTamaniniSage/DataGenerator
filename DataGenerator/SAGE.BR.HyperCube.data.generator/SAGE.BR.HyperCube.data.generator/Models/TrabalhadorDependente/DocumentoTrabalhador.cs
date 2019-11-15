using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class DocumentoTrabalhador
    {
        public string idTipoDocumento { get; set; }
        public string idTrabalhador { get; set; }
        public Documento[] documento { get; set; }
        public DateTime dataOperacao { get; set; }
    }

    public class Documento
    {
        public string chave { get; set; }
        public string valor { get; set; }
    }
   
}
