using System;
using System.Collections.Generic;
using System.Text;

namespace SAGE.BR.HyperCube.data.generator.Models.TrabalhadorDependente
{
    public class Trabalhador
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string nis { get; set; }
        public string nomeSocial { get; set; }
        public string idNacionalidade { get; set; }
        public Nacionalidade nacionalidadeReference { get; set; }
        public string idEstadoCivil { get; set; }
        public EstadoCivil estadoCivilReference { get; set; }
        public string status { get; set; }
        public string idGenero { get; set; }
        public Genero generoReference { get; set; }
        public string dataNascimento { get; set; }
        public int currentStep { get; set; }
        public ContratoTrabalho contratoTrabalhoReference { get; set; }
        public EnderecoTrabalhador enderecoTrabalhadorReference { get; set; }
        public ContatoTrabalhador contatoTrabalhadorReference { get; set; }
        public string idRaca { get; set; }
        public Raca racaReference { get; set; }
        public string idGrauInstrucao { get; set; }
        public GrauInstrucao grauInstrucaoReference { get; set; }
    }    
}
