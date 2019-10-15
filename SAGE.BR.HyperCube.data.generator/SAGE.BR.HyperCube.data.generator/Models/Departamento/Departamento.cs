using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.Departamento
{
    public class Departamento
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string idEmpresa { get; set; }
        public Empresareference empresaReference { get; set; }
        public string status { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Empresareference
    {
        public string subscriptionId { get; set; }
        public string id { get; set; }
        public string idContrato { get; set; }
        public int tpInsc { get; set; }
        public string nrInsc { get; set; }
        public string nmRazao { get; set; }
        public string idSituacaoPessoaJuridica { get; set; }
        public Situacaopessoajuridicareference situacaoPessoaJuridicaReference { get; set; }
        public string idCooperativa { get; set; }
        public Cooperativareference cooperativaReference { get; set; }
        public string idClassificacaoTributaria { get; set; }
        public Classificacaotributariareference classificacaoTributariaReference { get; set; }
        public string idNaturezaJuridica { get; set; }
        public Naturezajuridicareference naturezaJuridicaReference { get; set; }
        public int indConstr { get; set; }
        public int indDesFolha { get; set; }
        public int indOpcCP { get; set; }
        public int indOptRegEletron { get; set; }
        public bool indEntEd { get; set; }
        public bool indEtt { get; set; }
        public string nrRegEtt { get; set; }
        public int indAcordoIsenMulta { get; set; }
        public int indSitPF { get; set; }
        public string idCnae { get; set; }
        public string status { get; set; }
        public Cnaereference cnaeReference { get; set; }
        public string idAtividadeSimplesNacional { get; set; }
        public Atividadesimplesnacionalreference atividadeSimplesNacionalReference { get; set; }
        public int trabalhadoresAtivos { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Situacaopessoajuridicareference
    {
        public string id { get; set; }
        public string codigoSituacaoPessoaJuridica { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Cooperativareference
    {
        public string id { get; set; }
        public string codigoCooperativa { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Classificacaotributariareference
    {
        public string id { get; set; }
        public string codigoClassificacaoTributaria { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Naturezajuridicareference
    {
        public string id { get; set; }
        public string codigoNaturezaJuridica { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Cnaereference
    {
        public string id { get; set; }
        public string descricao { get; set; }
        public string codigoClassificacaoNacionalAtividadesEconomicas { get; set; }
        public int aliquotaRat { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Atividadesimplesnacionalreference
    {
        public string id { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deleteDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

}
