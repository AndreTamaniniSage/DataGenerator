using System;
using SAGE.BR.HyperCube.data.generator.Models;
using Newtonsoft.Json;
using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{
    public class EmpresaEstabelecimentoServiceSteps
    {
        private EmpresaEstabelecimentoService EmpresaEstabelecimentoService => new EmpresaEstabelecimentoService();
        public Estabelecimento OCadastroDaEmpresaComClassificacao(string ClassificacaoEmpresa)
        {
            Empresa Empresa = new Empresa();
            Estabelecimento EstabelecimentoMatriz = new Estabelecimento();
            EstabelecimentoParametro EstabelecimentoParametro = new EstabelecimentoParametro();

            //classificacaoTributaria
            //Simples nacional:
            //85C0C70C-C870-4193-858C-3513AEDC657D - 01 - Empresa enquadrada no regime de tributação Simples Nacional com tributação previdenciária substituída
            //LucroPresumido:
            //FC7B8C70-7E8F-4920-832B-47C2E3889DB2 - 04 - MEI - Micro Empreendedor Individual

            //atividadeSimplesNacional
            //Enquadramentos:
            //B3B44E9D-D08A-424A-9626-364DE3406B82 Tabela 5 Simples Nacional: Anexo 5 - Prestadores de Serviço
            //E0692264-48B8-45F9-B7B2-57BFB93F2B56 Tabela 2 Simples Nacional: Anexo 2 - Indústria
            //18732BAB-C829-486C-931A-B082A4645A1D Tabela 1 Simples Nacional: Anexo 1 - Comércio
            //5D660E86-75EF-4481-B1B2-BB390BCBF5CC Tabela 4 Simples Nacional: Anexo 4 - Prestadores de Serviço
            //4E615AEE-8851-4F72-B9AC-C4F2D90D95EA Tabela 3 Simples Nacional: Anexo 3 - Prestadores de Serviço

            switch (ClassificacaoEmpresa)
            {
                case "01":
                    Empresa.idClassificacaoTributaria = "85C0C70C-C870-4193-858C-3513AEDC657D";
                    Empresa.idAtividadeSimplesNacional = "18732BAB-C829-486C-931A-B082A4645A1D";
                    break;
                case "04":
                    Empresa.idClassificacaoTributaria = "FC7B8C70-7E8F-4920-832B-47C2E3889DB2";
                    Empresa.idAtividadeSimplesNacional = null;
                    break;
            }

            return EmpresaEstabelecimentoService.InsereEmpresaComEstabelecimentoMatriz(Empresa, EstabelecimentoParametro);
        }
        public Estabelecimento OCadastroDaEmpresaComAdiantamento(string ClassificaçãoTributaria, string PossuiAdiantamento, string DiaDeAdiantamento, string PorcentamCalculoAdiantamento, string CalcularAdiantamentoMesAdmissão)
        {

            Empresa Empresa = new Empresa();
            Estabelecimento EstabelecimentoMatriz = new Estabelecimento();
            EstabelecimentoParametroPeriodo EstabelecimentoParametroPeriodo = new EstabelecimentoParametroPeriodo();
            EstabelecimentoParametro EstabelecimentoParametro = new EstabelecimentoParametro();

            //classificacaoTributaria
            //Simples nacional:
            //85C0C70C-C870-4193-858C-3513AEDC657D - 01 - Empresa enquadrada no regime de tributação Simples Nacional com tributação previdenciária substituída
            //LucroPresumido:
            //FC7B8C70-7E8F-4920-832B-47C2E3889DB2 - 04 - MEI - Micro Empreendedor Individual

            //atividadeSimplesNacional
            //Enquadramentos:
            //B3B44E9D-D08A-424A-9626-364DE3406B82 Tabela 5 Simples Nacional: Anexo 5 - Prestadores de Serviço
            //E0692264-48B8-45F9-B7B2-57BFB93F2B56 Tabela 2 Simples Nacional: Anexo 2 - Indústria
            //18732BAB-C829-486C-931A-B082A4645A1D Tabela 1 Simples Nacional: Anexo 1 - Comércio
            //5D660E86-75EF-4481-B1B2-BB390BCBF5CC Tabela 4 Simples Nacional: Anexo 4 - Prestadores de Serviço
            //4E615AEE-8851-4F72-B9AC-C4F2D90D95EA Tabela 3 Simples Nacional: Anexo 3 - Prestadores de Serviço


            switch (ClassificaçãoTributaria)
            {
                case "01":
                    Empresa.idClassificacaoTributaria = "85C0C70C-C870-4193-858C-3513AEDC657D";
                    Empresa.idAtividadeSimplesNacional = "18732BAB-C829-486C-931A-B082A4645A1D";
                    break;
                case "04":
                    Empresa.idClassificacaoTributaria = "FC7B8C70-7E8F-4920-832B-47C2E3889DB2";
                    Empresa.idAtividadeSimplesNacional = null;
                    break;
            }

            if (PossuiAdiantamento.Equals("Sim"))
            {
                EstabelecimentoParametro.adiantamentoMensalHabilitado = true;
                EstabelecimentoParametro.adiantamentoMensalDia = DiaDeAdiantamento;
                EstabelecimentoParametro.adiantamentoMensalPercentual = PorcentamCalculoAdiantamento;


                if (CalcularAdiantamentoMesAdmissão.Equals("Sim"))
                {
                    EstabelecimentoParametro.adiantamentoMesAdmissao = true;
                    EstabelecimentoParametro.adiantamentoMesAdmissaoProporcional = true;
                }
            }
            else
            {
                EstabelecimentoParametro.adiantamentoMensalHabilitado = false;
            }

            return EmpresaEstabelecimentoService.InsereEmpresaComEstabelecimentoMatriz(Empresa, EstabelecimentoParametro);
        }
    }
}

