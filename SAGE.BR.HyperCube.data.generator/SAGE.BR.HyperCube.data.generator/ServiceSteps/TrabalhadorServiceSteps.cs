using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using SAGE.BR.HyperCube.data.generator.Models.Cargo;
using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using SAGE.BR.HyperCube.data.generator.Models.EmpresaEstabelecimento;
using SAGE.BR.HyperCube.data.generator.Models.Trabalhador;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{
    public class TrabalhadorServiceSteps
    {
        EmpresaServiceSteps EmpresaServiceSteps = new EmpresaServiceSteps();
        CargoServiceSteps CargoServiceSteps = new CargoServiceSteps();
        DepartamentoServiceSteps DepartamentoServiceSteps = new DepartamentoServiceSteps();
        
        public void OCadastroRapidoDoTrabalhadorComOContratoDeProLaborista()
        {
            Estabelecimento Estabelecimento = EmpresaServiceSteps.OCadastroRapidoDaEmpresaDoSimplesNacionalComClassificacao01();
            Cargo Cargo = CargoServiceSteps.OCadastroRapidoDoCargo();
            Departamento Departamento = DepartamentoServiceSteps.OCadastroRapidoDoDepartamentoComIdEmpresa(Estabelecimento.idEmpresa);

            string idGeneral = Guid.NewGuid().ToString();

            Trabalhador Trabalhador = new Trabalhador();
            Enderecotrabalhadorreference TrabalhadorEndereco = new Enderecotrabalhadorreference();
            Contatotrabalhadorreference TrabalhadorContato = new Contatotrabalhadorreference();
            Contratotrabalhoreference ContratoTrabalho = new Contratotrabalhoreference();
            Contratotrabalhohistoricoreference ContratoTrabalhoHistorico = new Contratotrabalhohistoricoreference();

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
            Trabalhador.deleteDate = null;
            Trabalhador.updateDate = null;

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
            TrabalhadorEndereco.deleteDate = null;
            TrabalhadorEndereco.updateDate = null;

            TrabalhadorContato.id = idGeneral;
            TrabalhadorContato.idTrabalhador = Trabalhador.id;
            TrabalhadorContato.email = "andre.tamanini@sage.com";
            TrabalhadorContato.telefone = "95983520367";
            TrabalhadorContato.deleteDate = null;
            TrabalhadorContato.updateDate = null;

            ContratoTrabalho.id = idGeneral;
            ContratoTrabalho.idEmpresa = Estabelecimento.idEmpresa;
            ContratoTrabalho.idEstabelecimento = Estabelecimento.id;
            ContratoTrabalho.idTrabalhador = Trabalhador.id;
            ContratoTrabalho.dataInicio = "2019-01-01 03:00:00.0000000";
            ContratoTrabalho.idTipoSalario = "9CABD094-62EF-4651-AEC7-7AEB60DC2FFC";
            ContratoTrabalho.matricula = FakeDataGenerator.FakeMatricula();
            ContratoTrabalho.possuiAdiantamento = true;
            ContratoTrabalho.deleteDate = null;
            ContratoTrabalho.updateDate = null;

            ContratoTrabalhoHistorico.id = idGeneral;
            ContratoTrabalhoHistorico.idContratoTrabalho = ContratoTrabalho.id;
            ContratoTrabalhoHistorico.idCargo = Cargo.id;
            ContratoTrabalhoHistorico.idDepartamento = Departamento.id;
            ContratoTrabalhoHistorico.idCategoriaTrabalhador = "BB187274-AC86-49A2-BAC3-170ABC33DC2A";
            ContratoTrabalhoHistorico.inicioVigencia = "2019-01-01";
            ContratoTrabalhoHistorico.fimVigencia = "3000-01-31";
            ContratoTrabalhoHistorico.salario = "5000.00";
            ContratoTrabalhoHistorico.horasMensais = "220.00";
            ContratoTrabalhoHistorico.deleteDate = null;
            ContratoTrabalhoHistorico.updateDate = null;


            Trabalhador.enderecoTrabalhadorReference = TrabalhadorEndereco;
            Trabalhador.contatoTrabalhadorReference = TrabalhadorContato;
            Trabalhador.contratoTrabalhoReference = ContratoTrabalho;
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
            doc5.valor = FakeDataGenerator.FakeDescricao(20);
            listaDocumentosRg.Add(doc5);
            doc6.chave = "numero";
            doc6.valor = FakeDataGenerator.FakeRg().Replace("-","").Replace(".","");
            listaDocumentosRg.Add(doc6);
            doc7.chave = "uf";
            doc7.valor = "BA";
            listaDocumentosRg.Add(doc7);
            documentoTrabalhadorRg.documento = listaDocumentosRg.ToArray();

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/documentotrabalhador", JsonConvert.SerializeObject(documentoTrabalhadorRg));

            JsonConvert.DeserializeObject<Trabalhador>(Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/contratotrabalhohistorico", JsonConvert.SerializeObject(ContratoTrabalhoHistorico)));

            Trabalhador.status = "A";

            JsonConvert.DeserializeObject<Trabalhador>(Services.PUT(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/trabalhador/"+Trabalhador.id, JsonConvert.SerializeObject(Trabalhador)));
        }

        public void InsereXEmpresaComXTrabalhadores(int Empresas, int trabalhadores)
        {
            for (int i = 0; i <Empresas; i++)
            {
                Estabelecimento Estabelecimento = new Estabelecimento();
                Estabelecimento = EmpresaServiceSteps.OCadastroRapidoDaEmpresaDoSimplesNacionalComClassificacao01();
                Departamento Departamento = DepartamentoServiceSteps.OCadastroRapidoDoDepartamentoComIdEmpresa(Estabelecimento.idEmpresa);
                Cargo Cargo = CargoServiceSteps.OCadastroRapidoDoCargo();

                for (int iTrabalhadores = 0; iTrabalhadores < trabalhadores; iTrabalhadores++)
                {
                    string idGeneral = Guid.NewGuid().ToString();
                    Trabalhador Trabalhador = new Trabalhador();
                    Enderecotrabalhadorreference TrabalhadorEndereco = new Enderecotrabalhadorreference();
                    Contatotrabalhadorreference TrabalhadorContato = new Contatotrabalhadorreference();
                    Contratotrabalhoreference ContratoTrabalho = new Contratotrabalhoreference();
                    Contratotrabalhohistoricoreference ContratoTrabalhoHistorico = new Contratotrabalhohistoricoreference();

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
                    Trabalhador.deleteDate = null;
                    Trabalhador.updateDate = null;

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
                    TrabalhadorEndereco.deleteDate = null;
                    TrabalhadorEndereco.updateDate = null;

                    TrabalhadorContato.id = idGeneral;
                    TrabalhadorContato.idTrabalhador = Trabalhador.id;
                    TrabalhadorContato.email = "andre.tamanini@sage.com";
                    TrabalhadorContato.telefone = "95983520367";
                    TrabalhadorContato.deleteDate = null;
                    TrabalhadorContato.updateDate = null;

                    ContratoTrabalho.id = idGeneral;
                    ContratoTrabalho.idEmpresa = Estabelecimento.idEmpresa;
                    ContratoTrabalho.idEstabelecimento = Estabelecimento.id;
                    ContratoTrabalho.idTrabalhador = Trabalhador.id;
                    ContratoTrabalho.dataInicio = "2019-01-01 03:00:00.0000000";
                    ContratoTrabalho.idTipoSalario = "9CABD094-62EF-4651-AEC7-7AEB60DC2FFC";
                    ContratoTrabalho.matricula = FakeDataGenerator.FakeMatricula();
                    ContratoTrabalho.possuiAdiantamento = true;
                    ContratoTrabalho.deleteDate = null;
                    ContratoTrabalho.updateDate = null;

                    ContratoTrabalhoHistorico.id = idGeneral;
                    ContratoTrabalhoHistorico.idContratoTrabalho = ContratoTrabalho.id;
                    ContratoTrabalhoHistorico.idCargo = Cargo.id;
                    ContratoTrabalhoHistorico.idDepartamento = Departamento.id;
                    ContratoTrabalhoHistorico.idCategoriaTrabalhador = "BB187274-AC86-49A2-BAC3-170ABC33DC2A";
                    ContratoTrabalhoHistorico.inicioVigencia = "2019-01-01";
                    ContratoTrabalhoHistorico.fimVigencia = "3000-01-31";
                    ContratoTrabalhoHistorico.salario = "5000.00";
                    ContratoTrabalhoHistorico.horasMensais = "220.00";
                    ContratoTrabalhoHistorico.deleteDate = null;
                    ContratoTrabalhoHistorico.updateDate = null;


                    Trabalhador.enderecoTrabalhadorReference = TrabalhadorEndereco;
                    Trabalhador.contatoTrabalhadorReference = TrabalhadorContato;
                    Trabalhador.contratoTrabalhoReference = ContratoTrabalho;
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
                    doc5.valor = FakeDataGenerator.FakeDescricao(20);
                    listaDocumentosRg.Add(doc5);
                    doc6.chave = "numero";
                    doc6.valor = FakeDataGenerator.FakeRg().Replace("-", "").Replace(".", "");
                    listaDocumentosRg.Add(doc6);
                    doc7.chave = "uf";
                    doc7.valor = "BA";
                    listaDocumentosRg.Add(doc7);
                    documentoTrabalhadorRg.documento = listaDocumentosRg.ToArray();

                    Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/documentotrabalhador", JsonConvert.SerializeObject(documentoTrabalhadorRg));

                    JsonConvert.DeserializeObject<Trabalhador>(Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/contratotrabalhohistorico", JsonConvert.SerializeObject(ContratoTrabalhoHistorico)));

                    Trabalhador.status = "A";

                    JsonConvert.DeserializeObject<Trabalhador>(Services.PUT(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/trabalhador/" + Trabalhador.id, JsonConvert.SerializeObject(Trabalhador)));
                }
            }
        }
    }
}

