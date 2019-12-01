using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SAGE.BR.HyperCube.data.generator.ServicesSteps;
namespace SAGE.BR.HyperCube.data.generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrabalhadorServiceSteps trabalhadorService = new TrabalhadorServiceSteps();

            var tasks = new List<Task>();

            tasks.Add(trabalhadorService.InsereXEmpresaSimplesComXMensalistasEXProlaboristas(1, 30, 1));

            tasks.Add(trabalhadorService.InsereXEmpresaComAdiantamentoSimplesComXMensalistas(1, 40));

            Task t = Task.WhenAll(tasks);
            t.Wait();
            Console.WriteLine("Terminou a inclusão da massa de Dados");
        }
    }
}