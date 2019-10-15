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
        public int pagamentoMensalDia { get; set; }
        public string pagamentoMensalDiaNaoUtil { get; set; }
        public bool adiantamentoMensalHabilitado { get; set; }
        public int adiantamentoMensalDia { get; set; }
        public string adiantamentoMensalDiaNaoUtil { get; set; }
        public int adiantamentoMensalPercentual { get; set; }
        public string idRegistroPonto { get; set; }
        public bool adiantamentoMesAdmissao { get; set; }
        public string adiantamentoMesAdmissaoProporcional { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

}
