using SAGE.BR.HyperCube.data.generator.Models.Cargo;
using Newtonsoft.Json;
using System;
using SAGE.BR.HyperCube.data.generator;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator.ServicesSteps
{
    public class CargoServiceSteps
    {
        public Cargo OCadastroRapidoDoCargo()
        {

            string idGeneral = Guid.NewGuid().ToString();

            Cargo Cargo = new Cargo();

            Cargo.id = idGeneral;
            Cargo.idClassificacaoBrasileiraOcupacao = "8814927D-1427-4EBD-BAC6-EBBC88E8C131";
            Cargo.descricao = FakeDataGenerator.FakeDescricao(20);
            Cargo.status = "A";
            Cargo.deleteDate = null;
            Cargo.updateDate = null;

            Cargo = JsonConvert.DeserializeObject<Cargo>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/cargo", JsonConvert.SerializeObject(Cargo)));


            return Cargo;
        }
    }
}
