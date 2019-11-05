using Bogus;
using Bogus.Extensions.Brazil;
using SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator
{
    public class DependenteTrabalhadorService
    {

        public void InsereDependenteTrabalhador(Trabalhador Trabalhador, DependenteTrabalhador DependenteTrabalhadorStep, DependenteTrabalhadorPeriodo DependenteTrabalhadorPeriodoStep)
        {
            DependenteTrabalhador DependenteTrabalhador = new DependenteTrabalhador();
            DependenteTrabalhadorPeriodo DependenteTrabalhadorPeriodo = new DependenteTrabalhadorPeriodo();

            string idGeneral = Guid.NewGuid().ToString();

            DependenteTrabalhador.id = idGeneral;
            DependenteTrabalhador.idTrabalhador = Trabalhador.id;
            DependenteTrabalhador.idTipoDependente = "453DDA3B-58D2-423B-A41A-9A2FA9CC3E32";
            DependenteTrabalhador.nome = FakeDataGenerator.FakeNomeCompleto();
            DependenteTrabalhador.cpf = FakeDataGenerator.FakeCpf();
            DependenteTrabalhador.possuiIncapacidade = true;
            DependenteTrabalhador.dataNascimento = "1997-10-12 02:00:00.0000000";
            DependenteTrabalhador.dependenteIRRF = DependenteTrabalhadorStep.dependenteIRRF;
            DependenteTrabalhador.dataMaximaIncidenciaIRRF = DependenteTrabalhadorStep.dataMaximaIncidenciaIRRF ?? "2300-10-15T19:18:48.445Z";

            DependenteTrabalhador = JsonConvert.DeserializeObject<DependenteTrabalhador>(Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/dependentetrabalhador", JsonConvert.SerializeObject(DependenteTrabalhador)));

            DependenteTrabalhadorPeriodo.id = idGeneral;
            DependenteTrabalhadorPeriodo.idDependenteTrabalhador = DependenteTrabalhador.id;
            DependenteTrabalhadorPeriodo.deduzIRRF = DependenteTrabalhadorPeriodoStep.deduzIRRF;
            DependenteTrabalhadorPeriodo.possuiIncapacidade = true;
            DependenteTrabalhadorPeriodo.inicioPeriodo = DependenteTrabalhadorPeriodoStep.inicioPeriodo ?? "2000-01-01T19:47:37.141Z";
            DependenteTrabalhadorPeriodo.fimPeriodo = DependenteTrabalhadorPeriodoStep.fimPeriodo ?? "2300-01-01T19:47:37.141Z";
            DependenteTrabalhadorPeriodo.idTipoDependente = "453DDA3B-58D2-423B-A41A-9A2FA9CC3E32";
        

            Services.POST(ServiceConfig.GetUrlHrm() + "/hypercube_hrm/v1/dependentetrabalhadorperiodo", JsonConvert.SerializeObject(DependenteTrabalhadorPeriodo));



        }
    }
}
