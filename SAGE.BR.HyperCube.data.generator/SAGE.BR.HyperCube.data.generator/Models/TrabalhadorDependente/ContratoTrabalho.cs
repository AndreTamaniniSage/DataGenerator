using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class ContratoTrabalho
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string idEmpresa { get; set; }
        public string idEstabelecimento { get; set; }
        public string dataInicio { get; set; }
        public string idTipoSalario { get; set; }
        public TipoSalario tipoSalarioReference { get; set; }
        public bool possuiAdiantamento { get; set; }
        public string matricula { get; set; }
        public ContratoTrabalhoHistorico contratoTrabalhoHistoricoReference { get; set; }
        public string salario { get; set; }
        public string idCategoriaTrabalhador { get; set; }
        public CategoriaTrabalhador categoriaTrabalhadorReference { get; set; }
    }
}
