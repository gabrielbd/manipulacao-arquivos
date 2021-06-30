using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Repositories
{
    //classe abstrata!
    public abstract class FuncionarioRepository
    {
        //método abstrato!
        public abstract void Exportar(Funcionario funcionario);
    }
}
