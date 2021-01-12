using Pettware_poo.Controller;
using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pettware_poo.View
{
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_AdicinarFornecedor_Click(object sender, EventArgs e)
        {
            tb_cidade.Enabled = true;
            tb_bairro.Enabled = true;
            tb_numero.Enabled = true;
            tb_uf.Enabled = true;
            tb_rua.Enabled = true;
            tb_nome.Enabled = true;
            tb_telefone.Enabled = true;
            tb_cnpj.Enabled = true;
            tb_Email.Enabled = true;
        }

        private void lb_uf_Click(object sender, EventArgs e)
        {

        }

        private void tb_uf_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.SetCnpj(tb_cnpj.ToString());
            fornecedor.SetEmail(tb_Email.ToString());
            fornecedor.SetNome(tb_nome.ToString());
            fornecedor.SetTelefone(tb_telefone.ToString());

            Endereco endereco = new Endereco();

            endereco.SetUf(tb_uf.ToString());
            endereco.SetCidade(tb_cidade.ToString());
            endereco.SetBairro(tb_bairro.ToString());
            endereco.SetLogradouro(tb_rua.ToString());
            endereco.SetNumero(tb_numero.ToString());

            fornecedor.SetEndereco(endereco);

            ControladorFornecedor controFornecedor = new ControladorFornecedor();
            controFornecedor.SetFornecedor(fornecedor);

            MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Confirmação");

            tb_nome.Text = "";
            tb_Email.Text = "";
            tb_telefone.Text = "";
            tb_cnpj.Text = "";
            tb_cidade.Text = "";
            tb_bairro.Text = "";
            tb_rua.Text = "";
            tb_numero.Text = "";
            tb_uf.Text = "";

            tb_cidade.Enabled = false;
            tb_bairro.Enabled = false;
            tb_numero.Enabled = false;
            tb_uf.Enabled = false;
            tb_rua.Enabled = false;
            tb_nome.Enabled = false;
            tb_telefone.Enabled = false;
            tb_cnpj.Enabled = false;
            tb_Email.Enabled = false;
        }
    }
}
