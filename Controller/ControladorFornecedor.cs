using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Controller
{
    public class ControladorFornecedor
    {
        private Fornecedor fornecedor;

        public ControladorFornecedor()
        {
        }

        public ControladorFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor = fornecedor;
        }

        public Fornecedor GetFornecedor()
        {
            return this.fornecedor;
        }
        public void SetFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor = fornecedor;
        }
    }
}
