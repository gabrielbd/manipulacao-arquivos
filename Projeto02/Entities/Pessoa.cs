using System;
using System.Collections.Generic;
using System.Text;

//define a localização da classe
namespace Projeto02.Entities
{
    //definição/declaração da classe
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
