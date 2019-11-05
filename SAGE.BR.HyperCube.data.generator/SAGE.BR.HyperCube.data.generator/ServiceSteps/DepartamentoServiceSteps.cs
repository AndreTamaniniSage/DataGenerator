using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using SAGE.BR.HyperCube.data.generator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{

    public class DepartamentoServiceSteps
    {
 
        public Departamento OCadastroRapidoDoDepartamento(string idEmpresa)
        {
            List<Empresa> Empresas = new List<Empresa>();

            Empresas = JsonConvert.DeserializeObject<List<Empresa>>(Services.GET(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/empresa/find?id="+ idEmpresa));

            string idGeneral = Guid.NewGuid().ToString();

            Departamento Departamento = new Departamento
            {
                id = idGeneral,
                idEmpresa = Empresas[0].Id,
                idTipoLotacao = "BAB0F96D-F8ED-47B6-85CA-680D548B2A32",
                descricao = FakeDataGenerator.FakeDescricao(50),
                status = "A"
            };

            Departamento = JsonConvert.DeserializeObject<Departamento>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/departamento", JsonConvert.SerializeObject(Departamento)));


            return Departamento;
        }
        public Setor OCadastroRapidoDoDepartamentoComSetorESecao(string idEmpresa)
        {
            string idGeneral = Guid.NewGuid().ToString();

            Departamento Departamento = OCadastroRapidoDoDepartamento(idEmpresa);

            Setor Setor = new Setor
            {
                id = idGeneral,
                idDepartamento = Departamento.id,
                idTipoLotacao = "BAB0F96D-F8ED-47B6-85CA-680D548B2A32",
                descricao = FakeDataGenerator.FakeDescricao(50)
        };

            Setor = JsonConvert.DeserializeObject<Setor>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/setor", JsonConvert.SerializeObject(Setor)));

            Setor.DepartamentoReference = Departamento;

            return Setor;
        }
    }
}
