using SAGE.BR.HyperCube.data.generator.Models;
using SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.PagamentoEvento
{
    public class PagamentoEventos
    {
        public string id { get; set; }
        public string idContratoTrabalho { get; set; }
        public ContratoTrabalho contratoTrabalhoReference { get; set; }
        public string idTrabalhador { get; set; }
        public Trabalhador trabalhadorReference { get; set; }
        public string idEstabelecimento { get; set; }
        public string idEmpresa { get; set; }
        public string idGrupoRubrica { get; set; }
        public GrupoRubrica grupoRubricaReference { get; set; }
        public string anoApuracao { get; set; }
        public string mesApuracao { get; set; }
        public string dataPagamento { get; set; }
        public string numero { get; set; }
        public string totalVencimentos { get; set; }
        public string totalInssBase { get; set; }
        public string totalInssContribuicao { get; set; }
        public string totalIrrfDeducao { get; set; }
        public string totalIrrfBase { get; set; }
        public string totalIrrfContribuicao { get; set; }
        public string totalDescontos { get; set; }
        public string totalPagamentoLiquido { get; set; }
        public string totalInssPatronal { get; set; }
        public string totalInssRat { get; set; }
        public string totalInssTerceiros { get; set; }
        public string totalFgtsBase { get; set; }
        public string totalFgtsValor { get; set; }
        public string remuneracaoBase { get; set; }
        public string idTipoPagamento { get; set; }
    }  
}
