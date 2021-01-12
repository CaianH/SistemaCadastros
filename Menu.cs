using Pettware_poo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pettware_poo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto cadpro = new CadProduto();
            cadpro.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultarproduto = new ConsultarProduto();
            consultarproduto.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadcliente = new CadastrarCliente();
            cadcliente.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarCliente concultCliente = new ConsultarCliente();
            concultCliente.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario cadFuncionario = new CadastrarFuncionario();
            cadFuncionario.ShowDialog();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario consultFuncionario = new ConsultarFuncionario();
            consultFuncionario.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadfornecedor = new CadastrarFornecedor();
            cadfornecedor.ShowDialog();
        }
    }
}
