using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models
{
    public class EstabelecimentoParametroPeriodo
    {
        public string id { get; set; }
        public string subscriptionId { get; set; }
        public string idEstabelecimento { get; set; }
        public string inicioPeriodo { get; set; }
        public string fimPeriodo { get; set; }
        public string aliquotaFap { get; set; }
        public string aliquotaRat { get; set; }
        public string aliquotaInssPatronal { get; set; }
        public string aliquotaInssTerceiros { get; set; }
        public string idFundoPrevidenciaAssistenciaSocial { get; set; }
        public string idReceitaContribuicaoPrevidenciaria { get; set; }
        public string inicioPeriodoAnoMes { get; set; }
        public string fimPeriodoAnoMes { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }
}
