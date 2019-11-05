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
        public string idTipoLotacao { get; set; }
        public string idEmpresa { get; set; }
        public Empresa empresaReference { get; set; }
        public string status { get; set; }
    }
}   
