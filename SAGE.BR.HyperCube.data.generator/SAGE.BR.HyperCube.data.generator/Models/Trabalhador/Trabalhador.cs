using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.Trabalhador
{
    public class Trabalhador
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string nis { get; set; }
        public string nomeSocial { get; set; }
        public string idNacionalidade { get; set; }
        public Nacionalidadereference nacionalidadeReference { get; set; }
        public string idEstadoCivil { get; set; }
        public Estadocivilreference estadoCivilReference { get; set; }
        public string status { get; set; }
        public string idGenero { get; set; }
        public Generoreference generoReference { get; set; }
        public string dataNascimento { get; set; }
        public int currentStep { get; set; }
        public Contratotrabalhoreference contratoTrabalhoReference { get; set; }
        public Enderecotrabalhadorreference enderecoTrabalhadorReference { get; set; }
        public Contatotrabalhadorreference contatoTrabalhadorReference { get; set; }
        public string idRaca { get; set; }
        public Racareference racaReference { get; set; }
        public string idGrauInstrucao { get; set; }
        public Grauinstrucaoreference grauInstrucaoReference { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Nacionalidadereference
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Estadocivilreference
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Generoreference
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Contratotrabalhoreference
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string idEmpresa { get; set; }
        public string idEstabelecimento { get; set; }
        public string dataInicio { get; set; }
        public string idTipoSalario { get; set; }
        public Tiposalarioreference tipoSalarioReference { get; set; }
        public bool possuiAdiantamento { get; set; }
        public string matricula { get; set; }
        public Contratotrabalhohistoricoreference contratoTrabalhoHistoricoReference { get; set; }
        public string salario { get; set; }
        public string idCategoriaTrabalhador { get; set; }
        public Categoriatrabalhadorreference1 categoriaTrabalhadorReference { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Tiposalarioreference
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Contratotrabalhohistoricoreference
    {
        public string horasMensais { get; set; }
        public string id { get; set; }
        public string idContratoTrabalho { get; set; }
        public string idCategoriaTrabalhador { get; set; }
        public Categoriatrabalhadorreference categoriaTrabalhadorReference { get; set; }
        public string inicioVigencia { get; set; }
        public string fimVigencia { get; set; }
        public string salario { get; set; }
        public string idCargo { get; set; }
        public string idDepartamento { get; set; }
        public string idSetor { get; set; }
        public string idSecao { get; set; }
        public string idJornadaTrabalho { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Categoriatrabalhadorreference
    {
        public string id { get; set; }
        public string codigoCategoriaTrabalhador { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Categoriatrabalhadorreference1
    {
        public string id { get; set; }
        public string codigoCategoriaTrabalhador { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Enderecotrabalhadorreference
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string codigoMunicipio { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Contatotrabalhadorreference
    {
        public string id { get; set; }
        public string idTrabalhador { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Racareference
    {
        public string id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }

    public class Grauinstrucaoreference
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public bool isDeleted { get; set; }
        public string deleteDate { get; set; }
        public string updateDate { get; set; }
        public string createDate { get; set; }
        public string deleteUserId { get; set; }
        public string updateUserId { get; set; }
        public string createUserId { get; set; }
    }
}
