using Newtonsoft.Json;
using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryJSON : FuncionarioRepository
    {
        public override void Exportar(Funcionario funcionario)
        {
            //transformar os dados do objeto funcionario para JSON (serialização)
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            //gerando um arquivo para escrita
            using (var streamWriter = new StreamWriter("c:\\temp\\funcionario.json"))
            {
                //escrevendo no arquivo
                streamWriter.WriteLine(json);
            }
        }
    }
}
