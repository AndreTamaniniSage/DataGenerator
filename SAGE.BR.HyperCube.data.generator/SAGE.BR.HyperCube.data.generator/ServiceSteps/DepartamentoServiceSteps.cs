using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using Newtonsoft.Json;
using System;
using SAGE.BR.HyperCube.data.generator;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{
    public class DepartamentoServiceSteps
    {
        public Departamento OCadastroRapidoDoDepartamentoComIdEmpresa(string idEmpresa)
        {

            string idGeneral = Guid.NewGuid().ToString();

            Departamento Departamento = new Departamento();

            Departamento.id = idGeneral;
            Departamento.idEmpresa = idEmpresa;
            Departamento.descricao = FakeDataGenerator.FakeDescricao(30);
            Departamento.deleteDate = null;
            Departamento.updateDate = null;
            Departamento.status = "A";

            Departamento = JsonConvert.DeserializeObject<Departamento>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/departamento", JsonConvert.SerializeObject(Departamento)));


            return Departamento;
        }
    }
}
