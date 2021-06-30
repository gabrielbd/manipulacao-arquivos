using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entities
{
    public class Funcionario : Pessoa
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Setor Setor { get; set; }
        public List<Funcao> Funcoes { get; set; }
    }
}
