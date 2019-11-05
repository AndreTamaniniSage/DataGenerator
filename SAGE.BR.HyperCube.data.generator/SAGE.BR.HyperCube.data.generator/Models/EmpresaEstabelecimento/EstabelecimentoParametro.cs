using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models
{
    public class EstabelecimentoParametro
    {
        public string id { get; set; }
        public string subscriptionId { get; set; }
        public string idEstabelecimento { get; set; }
        public string pagamentoMensalDia { get; set; }
        public string pagamentoMensalDiaNaoUtil { get; set; }
        public bool adiantamentoMensalHabilitado { get; set; }
        public string adiantamentoMensalDia { get; set; }
        public string adiantamentoMensalDiaNaoUtil { get; set; }
        public string adiantamentoMensalPercentual { get; set; }
        public string idRegistroPonto { get; set; }
        public bool adiantamentoMesAdmissao { get; set; }
        public bool adiantamentoMesAdmissaoProporcional { get; set; }
    }

}
