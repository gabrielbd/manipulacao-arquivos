using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void Exportar(Funcionario funcionario)
        {
            //criando um arquivo de extensão .txt
            using (var streamWriter = new StreamWriter("c:\\temp\\funcionario.txt"))
            {
                //escrevendo os dados do funcionario dentro do arquivo..
                streamWriter.WriteLine("Id do funcionário....: " + funcionario.Id);
                streamWriter.WriteLine("Nome do funcionário..: " + funcionario.Nome);
                streamWriter.WriteLine("Data de nascimento...: " + funcionario.DataNascimento);
                streamWriter.WriteLine("CPF..................: " + funcionario.Cpf);
                streamWriter.WriteLine("Matricula............: " + funcionario.Matricula);
                streamWriter.WriteLine("Data de admissão.....: " + funcionario.DataAdmissao);
                streamWriter.WriteLine("\n");
                streamWriter.WriteLine("Id do setor..........: " + funcionario.Setor.Id);
                streamWriter.WriteLine("Nome do setor........: " + funcionario.Setor.Nome);
                streamWriter.WriteLine("Descrição do setor...: " + funcionario.Setor.Descricao);
                streamWriter.WriteLine("\n");

                foreach (var item in funcionario.Funcoes)
                {
                    streamWriter.WriteLine("Id da função.........: " + item.Id);
                    streamWriter.WriteLine("Sigla da função......: " + item.Sigla);
                    streamWriter.WriteLine("Nome da função.......: " + item.Nome);
                    streamWriter.WriteLine("\n");
                }
            }
        }
    }
}
