using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.PagamentoEvento
{
    public class GrupoRubrica
    {
        public string id { get; set; }
        public string idTipoPgto { get; set; }
        public TipoPgto tipoPgtoReference { get; set; }
        public string idCategoriaTrabalhador { get; set; }
        public string descricao { get; set; }
    }
}
