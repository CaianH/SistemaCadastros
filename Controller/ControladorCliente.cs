using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Controller
{
    public class ControladorCliente
    {
        private Cliente cliente;

        public ControladorCliente()
        {
        }

        public ControladorCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente GetCliente()
        {
            return this.cliente;
        }
        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
    }
}
