using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento
{
    public class Estabelecimento
    {
        public string id { get; set; }
        public string idEmpresa { get; set; }
        public Empresa empresaReference { get; set; }
        public int tpEstabelecimento { get; set; }
        public int tpInsc { get; set; }
        public string nrInsc { get; set; }
        public string nmRazao { get; set; }
        public string idCnae { get; set; }
        public Cnae cnaeReferenceEstabelecimento { get; set; }
        public int tpCaepf { get; set; }
        public int indSubstPatrObra { get; set; }
        public string idRegistroPonto { get; set; }
        public string telefone { get; set; }
        public RegistroPonto registroPontoReference { get; set; }
        public string subscriptionId { get; set; }
        public string status { get; set; }
        public EnderecoEstabelecimento enderecoEstabelecimentoReference { get; set; }

    }
}
