using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models
{
    public class Empresa
    {
        public string subscriptionId { get; set; }
        public string Id { get; set; }
        public string idContrato { get; set; }
        public string tpInsc { get; set; }
        public string nrInsc { get; set; }
        public string nmRazao { get; set; }
        public string idSituacaoPessoaJuridica { get; set; }
        public SituacaoPessoaJuridica situacaoPessoaJuridicaReference { get; set; }
        public string idCooperativa { get; set; }
        public Cooperativa cooperativaReference { get; set; }
        public string idClassificacaoTributaria { get; set; }
        public ClassificacaoTributaria classificacaoTributariaReference { get; set; }
        public string idNaturezaJuridica { get; set; }
        public NaturezaJuridica naturezaJuridicaReference { get; set; }
        public string indConstr { get; set; }
        public string indOpcCP { get; set; }
        public string nrRegEtt { get; set; }
        public string indAcordoIsenMulta { get; set; }
        public string indSitPF { get; set; }
        public string idCnae { get; set; }
        public string status { get; set; }
        public Cnae cnaeReference { get; set; }
        public string idAtividadeSimplesNacional { get; set; }
        public AtividadeSimplesNacional atividadeSimplesNacionalReference { get; set; }
        public string trabalhadoresAtivos { get; set; }
    }
   
}
