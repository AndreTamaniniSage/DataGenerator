using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento
{
    public class EnderecoEstabelecimento
    {
        public string id { get; set; }
        public string idEstabelecimento { get; set; }
        public int tpEndereco { get; set; }
        public string tpLograd { get; set; }
        public string dscLograd { get; set; }
        public string nrLograd { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string codMunic { get; set; }
        public string nmMunic { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }
}
