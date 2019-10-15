using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.Cargo
{
    public class Cargo
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string idClassificacaoBrasileiraOcupacao { get; set; }
        public Classificacaobrasileiraocupacaoreference classificacaoBrasileiraOcupacaoReference { get; set; }
        public string status { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Classificacaobrasileiraocupacaoreference
    {
        public string id { get; set; }
        public string descricao { get; set; }
        public string codigoClassificacaoBrasileiraOcupacao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    
}
