using System;
using System.Threading.Tasks;
using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;
using SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{
    public class TrabalhadorServiceSteps
    {
        private EmpresaEstabelecimentoServiceSteps EmpresaServiceSteps = new EmpresaEstabelecimentoServiceSteps();

        private EmpresaEstabelecimentoService EmpresaEstabelecimentoService = new EmpresaEstabelecimentoService();
        private DependenteTrabalhadorService DependenteTrabalhadorService = new DependenteTrabalhadorService();
        private TrabalhadorContratoService TrabalhadorContratoService = new TrabalhadorContratoService();


        public Task InsereXEmpresaSimplesComXMensalistasEXProlaboristas(int numeroEmpresa, int numeroMensalistas, int numeroProlaboristas)
        {
            Parallel.For(0, numeroEmpresa, k =>
            {
                Console.WriteLine($"Incluindo empresa Class 01 {k + 1}/{numeroEmpresa}");
                Estabelecimento estabelecimento = EmpresaServiceSteps.OCadastroDaEmpresaComClassificacao("01");

                Parallel.For(0, numeroMensalistas, i =>
                {
                    Console.WriteLine($"Incluindo Mensalista {i + 1}/{numeroMensalistas} da empresa {estabelecimento.nmRazao}");
                    VerificaParametrosEInsereTrabalharContratoEHistoricoContrato("101",
                                                                                 "Não",
                                                                                  estabelecimento,
                                                                                  GetQtdDenpendentes(0, 2));


                });
                Parallel.For(0, numeroProlaboristas, n =>
                {
                    Console.WriteLine($"Incluindo Mensalista {n + 1}/{numeroProlaboristas} da empresa {estabelecimento.nmRazao} do tipo 722");
                    VerificaParametrosEInsereTrabalharContratoEHistoricoContrato("722",
                                                                                 "Não",
                                                                                 estabelecimento,
                                                                                 GetQtdDenpendentes(0, 1));
                    Console.WriteLine($"Incluindo Mensalista {n + 1}/{numeroProlaboristas} da empresa {estabelecimento.nmRazao} do tipo 723");
                    VerificaParametrosEInsereTrabalharContratoEHistoricoContrato("723",
                                                                                 "Não",
                                                                                 estabelecimento,
                                                                                 GetQtdDenpendentes(0, 2));
                });
            });
            return Task.CompletedTask;
        }
        public Task InsereXEmpresaComAdiantamentoSimplesComXMensalistas(int numeroEmpresa, int numeroMensalistas)
        {
            string PossuiAdiantamento = "Sim";
            string DiaDeAdiantamento = "15";
            string PorcentamCalculoAdiantamento = "40.00";
            string CalcularAdiantamentoMesAdmissão = "Sim";

            Parallel.For(0, numeroEmpresa, k =>
            {
                Console.WriteLine($"Incluindo empresa Class 01 {k + 1}/{numeroEmpresa}");
                Estabelecimento estabelecimento = EmpresaServiceSteps.OCadastroDaEmpresaComAdiantamento("01",
                                                                                            PossuiAdiantamento,
                                                                                            DiaDeAdiantamento,
                                                                                            PorcentamCalculoAdiantamento,
                                                                                            CalcularAdiantamentoMesAdmissão);
                Parallel.For(0, numeroMensalistas, i =>
                {
                    Console.WriteLine($"Incluindo Trabalhador {i + 1}/{numeroMensalistas} da empresa {estabelecimento.nmRazao}");
                    VerificaParametrosEInsereTrabalharContratoEHistoricoContrato("101",
                                                                                 "Sim",
                                                                                 estabelecimento,
                                                                                 GetQtdDenpendentes(0, 3));
                });
            });

            return Task.CompletedTask;
        }

        private int GetQtdDenpendentes(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }

        public void VerificaParametrosEInsereTrabalharContratoEHistoricoContrato(string CategoriaContrato, string Adiantamento, Estabelecimento Estabelecimento, int QuantidadeDependentesIrrf)
        {
            Trabalhador Trabalhador = new Trabalhador();
            ContratoTrabalho ContratoTrabalho = new ContratoTrabalho();
            ContratoTrabalhoHistorico ContratoTrabalhoHistorico = new ContratoTrabalhoHistorico();

            //Tipo salario
            // EAB1F26D-C2ED-4397-8F44-56192E05A22E	1	Mensalista
            // 9CABD094-62EF-4651-AEC7-7AEB60DC2FFC	2	Prolaborista

            //Categoria Trabalhador
            //BB187274-AC86-49A2-BAC3-170ABC33DC2A 722	Contribuinte individual - Diretor não empregado, sem FGTS
            //F022C37F-B513-4737-BC92-195102488256 723	Contribuinte individual empresários, sócios e membro de conselho de administração ou fiscal
            //02DF5B82-7B9E-46AE-9D92-25826EFD728B 101	Empregado - Geral, inclusive o empregado público da administração direta ou indireta contratado pela CLT

            switch (CategoriaContrato)
            {
                case "722":
                    ContratoTrabalho.idTipoSalario = "9CABD094-62EF-4651-AEC7-7AEB60DC2FFC";
                    ContratoTrabalhoHistorico.idCategoriaTrabalhador = "BB187274-AC86-49A2-BAC3-170ABC33DC2A";
                    break;
                case "723":
                    ContratoTrabalho.idTipoSalario = "9CABD094-62EF-4651-AEC7-7AEB60DC2FFC";
                    ContratoTrabalhoHistorico.idCategoriaTrabalhador = "F022C37F-B513-4737-BC92-195102488256";
                    break;
                case "101":
                    ContratoTrabalho.idTipoSalario = "EAB1F26D-C2ED-4397-8F44-56192E05A22E";
                    ContratoTrabalhoHistorico.idCategoriaTrabalhador = "02DF5B82-7B9E-46AE-9D92-25826EFD728B";
                    break;
                default:
                    ContratoTrabalho.idTipoSalario = "EAB1F26D-C2ED-4397-8F44-56192E05A22E";
                    ContratoTrabalhoHistorico.idCategoriaTrabalhador = "02DF5B82-7B9E-46AE-9D92-25826EFD728B";
                    break;
            }

            if (Adiantamento.Equals("Sim"))
                ContratoTrabalho.possuiAdiantamento = true;
            else
                ContratoTrabalho.possuiAdiantamento = false;


            Trabalhador = TrabalhadorContratoService.InsereTrabalhadorComOContratoParaOEstabelecimento(Estabelecimento, ContratoTrabalho, ContratoTrabalhoHistorico);
            Parallel.For(0, QuantidadeDependentesIrrf, i =>
            {
                Console.WriteLine($"Incluindo Dependente {i + 1}/{QuantidadeDependentesIrrf} do trabalhador {Trabalhador.nome}");
                DependenteTrabalhador DependenteTrabalhador = new DependenteTrabalhador();
                DependenteTrabalhadorPeriodo DependenteTrabalhadorPeriodo = new DependenteTrabalhadorPeriodo();
                DependenteTrabalhador.dependenteIRRF = true;
                DependenteTrabalhadorPeriodo.deduzIRRF = true;

                DependenteTrabalhadorService.InsereDependenteTrabalhador(Trabalhador, DependenteTrabalhador, DependenteTrabalhadorPeriodo);
            });
        }
    }
}


