using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryXML : FuncionarioRepository
    {
        public override void Exportar(Funcionario funcionario)
        {
            //serializando os dados do funcionario para XML..
            var xml = new XmlSerializer(funcionario.GetType());

            //gravando em arquivo
            using (var streamWriter = new StreamWriter("c:\\temp\\funcionario.xml"))
            {
                //escrevendo o conteudo XML no arquivo
                xml.Serialize(streamWriter, funcionario);
            }
        }
    }
}
