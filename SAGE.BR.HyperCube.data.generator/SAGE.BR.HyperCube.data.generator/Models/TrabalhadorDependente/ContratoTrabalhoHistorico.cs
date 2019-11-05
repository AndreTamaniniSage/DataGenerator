using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class ContratoTrabalhoHistorico
    {
        public string horasMensais { get; set; }
        public string id { get; set; }
        public string idContratoTrabalho { get; set; }
        public string idCategoriaTrabalhador { get; set; }
        public CategoriaTrabalhador categoriaTrabalhadorReference { get; set; }
        public string inicioVigencia { get; set; }
        public string fimVigencia { get; set; }
        public string salario { get; set; }
        public string idCargo { get; set; }
        public string idDepartamento { get; set; }
        public string idSetor { get; set; }
        public string idSecao { get; set; }
        public string idJornadaTrabalho { get; set; }
    }

}
