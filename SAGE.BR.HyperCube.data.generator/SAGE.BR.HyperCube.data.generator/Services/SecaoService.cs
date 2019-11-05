using System;
using System.Collections.Generic;
using System.Text;
using SAGE.BR.HyperCube.data.generator.Models;
using SAGE.BR.HyperCube.data.generator.Models.Departamento;
using Newtonsoft.Json;
using SAGE.BR.HyperCube.data.generator.Utils;

namespace SAGE.BR.HyperCube.data.generator
{
    public class SecaoService
    {
        public Secao InsereSecaoPorIdDoSetor(string idSetor)
        {
            string idGeneral = Guid.NewGuid().ToString();

            Secao Secao = new Secao
            {
                id = idGeneral,
                idSetor = idSetor,
                idTipoLotacao = "BAB0F96D-F8ED-47B6-85CA-680D548B2A32",
                descricao = FakeDataGenerator.FakeDescricao(50),
            };

            Secao = JsonConvert.DeserializeObject<Secao>(Services.POST(ServiceConfig.GetUrlAdm() + "/hypercube_adm/v1/secao", JsonConvert.SerializeObject(Secao)));

            return Secao;

        }
    }
}
