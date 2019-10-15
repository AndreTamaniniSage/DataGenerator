using System;
using SAGE.BR.HyperCube.data.generator.ServicesSteps;
namespace SAGE.BR.HyperCube.data.generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrabalhadorServiceSteps trabalhadorService = new TrabalhadorServiceSteps();

            trabalhadorService.InsereXEmpresaComXTrabalhadores(2,10);
        }
    }
}
