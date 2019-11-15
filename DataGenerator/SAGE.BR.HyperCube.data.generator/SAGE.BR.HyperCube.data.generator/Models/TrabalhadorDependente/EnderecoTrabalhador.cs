using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class EnderecoTrabalhador
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string codigoMunicipio { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }   
    }

}
