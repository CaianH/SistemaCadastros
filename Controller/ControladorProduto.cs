using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Controller
{
    public class ControladorProduto
    {
        private Produto produto;

        public ControladorProduto()
        {
        }

        public ControladorProduto(Produto produto)
        {
            this.produto = produto;
        }

        public void SetProduto(Produto produto)
        {
            this.produto = produto;
        }
        public Produto GetProduto()
        {
            return this.produto;
        }
    }
}
