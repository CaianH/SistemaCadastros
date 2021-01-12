using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Controller
{
    public class ControladorFuncionario
    {
        private Funcionario funcionario;

        public ControladorFuncionario()
        {
        }

        public ControladorFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public Funcionario GetFuncionario()
        {
            return this.funcionario;
        }
        public void SetFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }
    }
}
