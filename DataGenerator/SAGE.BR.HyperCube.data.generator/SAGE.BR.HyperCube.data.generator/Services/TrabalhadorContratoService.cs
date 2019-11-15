using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using SAGE.BR.HyperCube.data.generator.Models.Cargo;
using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;
using SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente;
using SAGE.BR.HyperCube.data.generator.ServicesSteps;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator
{
    public class TrabalhadorContratoService
    {
        private EmpresaEstabelecimentoServiceSteps EmpresaServiceSteps => new EmpresaEstabelecimentoServiceSteps();
        private CargoServiceSteps CargoServiceSteps => new CargoServiceSteps();
        private DepartamentoServiceSteps DepartamentoServiceSteps => new DepartamentoServiceSteps();
        private SecaoService SecaoService => new SecaoService();

        public Trabalhador InsereTrabalhadorComOContratoParaOEstabelecimento(Estabelecimento estabelecimento, ContratoTrabalho ContratoTrabalhoStep, ContratoTrabalhoHistorico ContratoTrabalhoHistoricoStep)
        {
            Cargo Cargo = CargoServiceSteps.OCadastroRapidoDoCargo();
            Setor Setor = DepartamentoServiceSteps.OCadastroRapidoDoDepartamentoComSetorESecao(estabelecimento.idEmpresa);
            Secao Secao = SecaoService.InsereSecaoPorIdDoSetor(Setor.id);

            string idGeneral = Guid.NewGuid().ToString();

            Trabalhador Trabalhador = new Trabalhador();
            EnderecoTrabalhador TrabalhadorEndereco = new EnderecoTrabalhador();
            ContatoTrabalhador TrabalhadorContato = new ContatoTrabalhador();
            ContratoTrabalho ContratoTrabalho = new ContratoTrabalho();
            ContratoTrabalhoHistorico ContratoTrabalhoHistorico = new ContratoTrabalhoHistorico();

            Trabalhador.id = idGeneral;
            Trabalhador.nome = FakeDataGenerator.FakeNomeCompleto();
            Trabalhador.cpf = FakeDataGenerator.FakeCpf();
            Trabalhador.nis = FakeDataGenerator.FakeNis();
            Trabalhador.status = "A";
            Trabalhador.dataNascimento = "1988-02-19 03:00:00.0000000";
            Trabalhador.idEstadoCivil = "CAC9D956-8CD5-4FB9-B87B-9EB8F683E49A";
            Trabalhador.idGenero = "3C384655-1F59-4CBA-9BDF-9C915673BD7D";
            Trabalhador.idGrauInstrucao = "29003908-FF64-4B54-899A-080A398FA634";
            Trabalhador.idNacionalidade = "A91D4871-01DE-4996-BAF4-8B67E0ECA0B5";
            Trabalhador.idRaca = "EB86CB87-52D5-472A-93F5-F7D2CEA83089";

            TrabalhadorEndereco.id = idGeneral;
            TrabalhadorEndereco.idTrabalhador = Trabalhador.id;
            TrabalhadorEndereco.numero = "123";
            TrabalhadorEndereco.logradouro = "Av. Marcello Braquini";
            TrabalhadorEndereco.complemento = "";
            TrabalhadorEndereco.municipio = "Araraquara";
            TrabalhadorEndereco.codigoMunicipio = "3503208";
            TrabalhadorEndereco.bairro = "Jardim Arangá";
            TrabalhadorEndereco.uf = "SP";
            TrabalhadorEndereco.cep = "14807092";

            TrabalhadorContato.id = idGeneral;
            TrabalhadorContato.idTrabalhador = Trabalhador.id;
            TrabalhadorContato.email = "andre.tamanini@sage.com";
            TrabalhadorContato.telefone = "95983520367";

            Trabalhador.enderecoTrabalhadorReference = TrabalhadorEndereco;
            Trabalhador.contatoTrabalhadorReference = TrabalhadorContato;
            Trabalhador = JsonConvert.DeserializeObject<Trabalhador>(Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/trabalhador", JsonConvert.SerializeObject(Trabalhador)));

            //DocumentoTrabalhador
            DocumentoTrabalhador documentoTrabalhadorCarteiraTrabalho = new DocumentoTrabalhador();
            Documento doc1 = new Documento();
            Documento doc2 = new Documento();
            Documento doc3 = new Documento();
            List<Documento> listaDocumentosCarteiraTrabalho = new List<Documento>();
            documentoTrabalhadorCarteiraTrabalho.idTrabalhador = Trabalhador.id;
            documentoTrabalhadorCarteiraTrabalho.idTipoDocumento = "75F5E19B-35CD-4864-AA2B-FDFEC59EC849";
            doc1.chave = "uf";
            doc1.valor = "PR";
            listaDocumentosCarteiraTrabalho.Add(doc1);
            doc2.chave = "serie";
            doc2.valor = "1111-1";
            listaDocumentosCarteiraTrabalho.Add(doc2);
            doc3.chave = "numero";
            doc3.valor = "11111111111";
            listaDocumentosCarteiraTrabalho.Add(doc3);
            documentoTrabalhadorCarteiraTrabalho.documento = listaDocumentosCarteiraTrabalho.ToArray();

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/documentotrabalhador", JsonConvert.SerializeObject(documentoTrabalhadorCarteiraTrabalho));

            DocumentoTrabalhador documentoTrabalhadorRg = new DocumentoTrabalhador();
            Documento doc4 = new Documento();
            Documento doc5 = new Documento();
            Documento doc6 = new Documento();
            Documento doc7 = new Documento();
            List<Documento> listaDocumentosRg = new List<Documento>();
            documentoTrabalhadorRg.idTrabalhador = Trabalhador.id;
            documentoTrabalhadorRg.idTipoDocumento = "BADE9CEB-DA90-4077-BB72-32DCF5C1751F";
            doc4.chave = "dataExpedicao";
            doc4.valor = "1997-10-15T02:00:00.000Z";
            listaDocumentosRg.Add(doc4);
            doc5.chave = "orgaoEmissor";
            doc5.valor = "fae242fb-932d-4d58-8b70-73c05685dc6d";
            listaDocumentosRg.Add(doc5);
            doc6.chave = "numero";
            doc6.valor = FakeDataGenerator.FakeRg().Replace("-", "").Replace(".", "");
            listaDocumentosRg.Add(doc6);
            doc7.chave = "uf";
            doc7.valor = "BA";
            listaDocumentosRg.Add(doc7);
            documentoTrabalhadorRg.documento = listaDocumentosRg.ToArray();

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/documentotrabalhador", JsonConvert.SerializeObject(documentoTrabalhadorRg));


            ContratoTrabalho.id = idGeneral;
            ContratoTrabalho.idEmpresa = estabelecimento.idEmpresa;
            ContratoTrabalho.idEstabelecimento = estabelecimento.id;
            ContratoTrabalho.idTrabalhador = Trabalhador.id;
            ContratoTrabalho.dataInicio = ContratoTrabalhoStep.dataInicio ?? "2019-01-01 03:00:00.0000000";
            ContratoTrabalho.idTipoSalario = ContratoTrabalhoStep.idTipoSalario ?? "9CABD094-62EF-4651-AEC7-7AEB60DC2FFC";
            ContratoTrabalho.matricula = FakeDataGenerator.FakeMatricula();
            ContratoTrabalho.possuiAdiantamento = ContratoTrabalhoStep.possuiAdiantamento;

            ContratoTrabalho = JsonConvert.DeserializeObject<ContratoTrabalho>(Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/contratotrabalho/", JsonConvert.SerializeObject(ContratoTrabalho)));

            ContratoTrabalhoHistorico.id = idGeneral;
            ContratoTrabalhoHistorico.idContratoTrabalho = ContratoTrabalho.id;
            ContratoTrabalhoHistorico.idCargo = Cargo.id;
            ContratoTrabalhoHistorico.idDepartamento = Setor.DepartamentoReference.id;
            ContratoTrabalhoHistorico.idSetor = Setor.id;
            ContratoTrabalhoHistorico.idSecao = Secao.id;
            ContratoTrabalhoHistorico.idCategoriaTrabalhador = ContratoTrabalhoHistoricoStep.idCategoriaTrabalhador ?? "BB187274-AC86-49A2-BAC3-170ABC33DC2A";
            ContratoTrabalhoHistorico.inicioVigencia = "2019-01-01";
            ContratoTrabalhoHistorico.fimVigencia ="3000-01-31";
            ContratoTrabalhoHistorico.salario = "2456.99";
            ContratoTrabalhoHistorico.horasMensais = "220.00";


            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/contratotrabalhohistorico", JsonConvert.SerializeObject(ContratoTrabalhoHistorico));

            Trabalhador.status = "A";

            Services.PUT(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/trabalhador/" + Trabalhador.id, JsonConvert.SerializeObject(Trabalhador));

            return Trabalhador;

        }
    }
}
