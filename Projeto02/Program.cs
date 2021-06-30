using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n -- EXPORTADOR DE DADOS DE FUNCIONARIOS --\n");

            var funcionario = new Funcionario();
            funcionario.Setor = new Setor();
            funcionario.Funcoes = new List<Funcao>();

            try
            {               
                funcionario.Id = Guid.NewGuid();  //gerando o ID do funcionario..
                funcionario.Setor.Id = Guid.NewGuid(); //gerando o ID do setor..

                Console.Write("Informe o nome do funcionário......: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Informe a data de nascimento.......: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o CPF do funcionário.......: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Informe a matrícula do funcionário.: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("Informe a data de admissão.........: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o nome do setor............: ");
                funcionario.Setor.Nome = Console.ReadLine();

                Console.Write("Informe a descrição do setor.......: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                Console.Write("\nInforme a quantidade de funções....: ");
                var quantidade = int.Parse(Console.ReadLine());

                //loop
                for (int i = 0; i < quantidade; i++)
                {
                    var funcao = new Funcao();
                    funcao.Id = Guid.NewGuid();

                    Console.Write("\nInforme a sigla da função..........: ");
                    funcao.Sigla = Console.ReadLine();

                    Console.Write("Informe o nome da função...........: ");
                    funcao.Nome = Console.ReadLine();

                    //adicionando a função dentro do funcionario
                    funcionario.Funcoes.Add(funcao);
                }

                Console.Write("\nInforme o tipo de arquivo desejado.: ");
                var tipoArquivo = Console.ReadLine();

                //criando um objeto da classe abstrata (FuncionarioRepository)
                FuncionarioRepository funcionarioRepository = null; //vazio

                //verificar se foi digitado a opção TXT
                if(tipoArquivo.Equals("TXT", StringComparison.OrdinalIgnoreCase))
                {
                    //exportando o arquivo
                    funcionarioRepository = new FuncionarioRepositoryTXT(); //POLIMORFISMO
                    funcionarioRepository.Exportar(funcionario);

                    Console.WriteLine("\nArquivo TXT gravado com sucesso.");
                }
                else if(tipoArquivo.Equals("XML", StringComparison.OrdinalIgnoreCase))
                {
                    //exportando o arquivo
                    funcionarioRepository = new FuncionarioRepositoryXML(); //POLIMORFISMO
                    funcionarioRepository.Exportar(funcionario);

                    Console.WriteLine("\nArquivo XML gravado com sucesso.");
                }
                else if(tipoArquivo.Equals("JSON", StringComparison.OrdinalIgnoreCase))
                {
                    //exportando o arquivo
                    funcionarioRepository = new FuncionarioRepositoryJSON(); //POLIMORFISMO
                    funcionarioRepository.Exportar(funcionario);

                    Console.WriteLine("\nArquivo JSON gravado com sucesso.");
                }
                else
                {
                    Console.WriteLine("\nTipo de arquivo inválido.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            Console.ReadKey(); //pausar o prompt
        }
    }    
}
