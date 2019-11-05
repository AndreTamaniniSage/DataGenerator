using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;
using System;
using SAGE.BR.HyperCube.data.generator.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator
{
    public class EmpresaEstabelecimentoService
    { 
        public Estabelecimento InsereEmpresaComEstabelecimentoMatriz(Empresa EmpresaStep, EstabelecimentoParametro EstabelecimentoParametroMatrizStep)
        {
            string idGeneral = Guid.NewGuid().ToString();


            Empresa Empresa = new Empresa();
            Estabelecimento EstabelecimentoMatriz = new Estabelecimento();
            EnderecoEstabelecimento enderecoEstabelecimento = new EnderecoEstabelecimento();

            Empresa.Id = idGeneral;
            Empresa.nrInsc = FakeDataGenerator.FakeCnpj().Replace(".", "").Replace("/", "").Replace("-", "");
            Empresa.idCnae = "13B1619D-EE89-4BA3-A03A-7E392F037B19";
            Empresa.nmRazao = FakeDataGenerator.FakeNomeDaEmpresa();
            Empresa.idSituacaoPessoaJuridica = "724BFCEB-8C86-4C3E-B88D-1951A88C2D8C";
            Empresa.idClassificacaoTributaria = EmpresaStep.idClassificacaoTributaria ?? "85C0C70C-C870-4193-858C-3513AEDC657D";
            Empresa.idAtividadeSimplesNacional = EmpresaStep.idAtividadeSimplesNacional ?? null;
            Empresa.idCooperativa = "263C627C-4D09-49C7-BBB3-1CADD34FA800";
            Empresa.idContrato = "BF6513E0-7CAC-4CED-B05C-347198285EF0";
            Empresa.idNaturezaJuridica = "70373266-1BB1-49EE-BEE6-0B1405016215";
            Empresa.tpInsc = "1";
            Empresa.status = "A";
            Empresa.indConstr = "1";
            Empresa.indOpcCP = null;

            Empresa = JsonConvert.DeserializeObject<Empresa>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/empresa", JsonConvert.SerializeObject(Empresa)));

            EstabelecimentoMatriz.id = idGeneral;
            EstabelecimentoMatriz.idEmpresa = Empresa.Id;
            EstabelecimentoMatriz.tpEstabelecimento = 1;
            EstabelecimentoMatriz.tpInsc = 1;
            EstabelecimentoMatriz.telefone = "19994198982";
            EstabelecimentoMatriz.nrInsc = FakeDataGenerator.FakeCnpj().Replace(".", "").Replace("/", "").Replace("-", "");
            EstabelecimentoMatriz.nmRazao = FakeDataGenerator.FakeNomeDaEmpresa();
            EstabelecimentoMatriz.idCnae = "13B1619D-EE89-4BA3-A03A-7E392F037B19";
            EstabelecimentoMatriz.idRegistroPonto = "733D9D22-E3C8-4321-8A3A-5AC56F9E1B46";
            EstabelecimentoMatriz.status = "A";

            enderecoEstabelecimento.id = idGeneral;
            enderecoEstabelecimento.idEstabelecimento = idGeneral;
            enderecoEstabelecimento.tpEndereco = 1;
            enderecoEstabelecimento.tpLograd = "0";
            enderecoEstabelecimento.dscLograd = "Avenida Marcello Braguini";
            enderecoEstabelecimento.nrLograd = "1234";
            enderecoEstabelecimento.bairro = "Jardim Arangá";
            enderecoEstabelecimento.codMunic = "1";
            enderecoEstabelecimento.nmMunic = "Araraquara";
            enderecoEstabelecimento.uf = "SP";
            enderecoEstabelecimento.cep = "13466200";

            EstabelecimentoMatriz.enderecoEstabelecimentoReference = enderecoEstabelecimento;

            EstabelecimentoMatriz = JsonConvert.DeserializeObject<Estabelecimento>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/estabelecimento", JsonConvert.SerializeObject(EstabelecimentoMatriz)));

            EstabelecimentoParametroPeriodo EstabelecimentoParametroPeriodoMatriz = new EstabelecimentoParametroPeriodo();

            EstabelecimentoParametroPeriodoMatriz.id = idGeneral;
            EstabelecimentoParametroPeriodoMatriz.idEstabelecimento = EstabelecimentoMatriz.id;
            EstabelecimentoParametroPeriodoMatriz.subscriptionId = EstabelecimentoMatriz.subscriptionId;
            EstabelecimentoParametroPeriodoMatriz.inicioPeriodo = "2019-01-01";
            EstabelecimentoParametroPeriodoMatriz.fimPeriodo = "2099-12-31";
            EstabelecimentoParametroPeriodoMatriz.codigoTerceiros = "0115";
            EstabelecimentoParametroPeriodoMatriz.inicioPeriodoAnoMes ="01/2019";
            EstabelecimentoParametroPeriodoMatriz.fimPeriodoAnoMes ="12/2099";
            EstabelecimentoParametroPeriodoMatriz.aliquotaFap = "1.0000";
            EstabelecimentoParametroPeriodoMatriz.aliquotaRat ="5.00";
            EstabelecimentoParametroPeriodoMatriz.aliquotaInssPatronal = "20.00";
            EstabelecimentoParametroPeriodoMatriz.idFundoPrevidenciaAssistenciaSocial = "62FD451E-5013-4A5E-AE28-831C5C65FB18";
            EstabelecimentoParametroPeriodoMatriz.idReceitaContribuicaoPrevidenciaria = "91A1DCD3-A975-4B79-9617-B1EEA5F9EE5C";
            EstabelecimentoParametroPeriodoMatriz.aliquotaInssTerceiros = "2.70";
            EstabelecimentoParametroPeriodoMatriz.nomeContato =  "Default";
            EstabelecimentoParametroPeriodoMatriz.responsavelTransmissao = "Empresa";

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/estabelecimentoparametroperiodo", JsonConvert.SerializeObject(EstabelecimentoParametroPeriodoMatriz));

            EstabelecimentoParametro EstabelecimentoParametroMatriz = new EstabelecimentoParametro();
            EstabelecimentoParametroMatriz.id = idGeneral;
            EstabelecimentoParametroMatriz.idEstabelecimento = EstabelecimentoMatriz.id;
            EstabelecimentoParametroMatriz.pagamentoMensalDia = EstabelecimentoParametroMatrizStep.pagamentoMensalDia ?? "28";
            EstabelecimentoParametroMatriz.pagamentoMensalDiaNaoUtil = EstabelecimentoParametroMatrizStep.pagamentoMensalDiaNaoUtil ?? "Nenhum";
            EstabelecimentoParametroMatriz.adiantamentoMensalHabilitado = EstabelecimentoParametroMatrizStep.adiantamentoMensalHabilitado;
            EstabelecimentoParametroMatriz.adiantamentoMensalDiaNaoUtil = EstabelecimentoParametroMatrizStep.adiantamentoMensalDiaNaoUtil ?? "Nenhum";
            EstabelecimentoParametroMatriz.adiantamentoMensalDia = EstabelecimentoParametroMatrizStep.adiantamentoMensalDia ?? "15";
            EstabelecimentoParametroMatriz.adiantamentoMensalPercentual = EstabelecimentoParametroMatrizStep.adiantamentoMensalPercentual ?? "40.00";
            EstabelecimentoParametroMatriz.adiantamentoMesAdmissao = EstabelecimentoParametroMatrizStep.adiantamentoMesAdmissao;
            EstabelecimentoParametroMatriz.adiantamentoMesAdmissaoProporcional = EstabelecimentoParametroMatrizStep.adiantamentoMesAdmissaoProporcional;
            EstabelecimentoParametroMatriz.subscriptionId = EstabelecimentoMatriz.subscriptionId;
            EstabelecimentoParametroMatriz.idRegistroPonto = "CA09D73B-4028-4F93-BD0B-C20639EDB8B4";

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/estabelecimentoparametro", JsonConvert.SerializeObject(EstabelecimentoParametroMatriz));


            return EstabelecimentoMatriz;
        }

        public Estabelecimento RetornaEstabelecimentoPorCnpj(string Cnpj)
        {
            List<Empresa> Empresas = new List<Empresa>();
            List<Estabelecimento> Estabelecimentos = new List<Estabelecimento>();

            Empresas = JsonConvert.DeserializeObject<List<Empresa>>(Services.GET(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/empresa/find?nrInsc=" + Cnpj.Replace(".", "").Replace("/", "").Replace("-", "")));
            Estabelecimentos = JsonConvert.DeserializeObject<List<Estabelecimento>>(Services.GET(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/estabelecimento/find?idEmpresa="+Empresas[0].Id));

            return Estabelecimentos[0];
        }
    }
}
