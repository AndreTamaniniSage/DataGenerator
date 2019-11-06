using System;
using SAGE.BR.HyperCube.data.generator.ServicesSteps;
namespace SAGE.BR.HyperCube.data.generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrabalhadorServiceSteps trabalhadorService = new TrabalhadorServiceSteps();

            trabalhadorService.InsereXEmpresaSimplesComXMensalistasEXProlaboristas(2,20, 10);

            trabalhadorService.InsereXEmpresaComAdiantamentoSimplesComXMensalistas(2, 40);
        }
    }
}
