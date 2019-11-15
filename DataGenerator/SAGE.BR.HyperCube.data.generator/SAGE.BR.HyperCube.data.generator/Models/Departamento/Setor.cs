using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.Departamento
{
    public class Setor
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string idDepartamento { get; set; }
        public Departamento DepartamentoReference { get; set; }
        public string idTipoLotacao { get; set; }
    }
}
