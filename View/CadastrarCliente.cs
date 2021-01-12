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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.SetNome(tb_nome.ToString());
            cliente.SetEmail(tb_Email.ToString());
            cliente.SetRg(tb_rg.ToString());
            cliente.SetNacionalidade(tb_nacionalidade.ToString());
            cliente.SetNaturalidade(tb_naturalidade.ToString());
            cliente.SetTelefone(tb_telefone.ToString());
            cliente.SetData_nascimento(tb_datanascimento.ToString());
            cliente.SetCpf(long.Parse(tb_cpf.Text));
            cliente.SetCodigo(Convert.ToInt32(tb_codigo.Text));

            Endereco endereco = new Endereco();
            endereco.SetCidade(tb_cidade.ToString());
            endereco.SetBairro(tb_bairro.ToString());
            endereco.SetLogradouro(tb_rua.ToString());
            endereco.SetNumero(tb_numero.ToString());

            cliente.SetEndereco(endereco);

            ControladorCliente controlCliente = new ControladorCliente();
            controlCliente.SetCliente(cliente);

            MessageBox.Show("Produto Cadastrado com Sucesso!","Confirmação");

            tb_nome.Text = "";
            tb_Email.Text = "";
            tb_datanascimento.Text = "";
            tb_nacionalidade.Text = "";
            tb_naturalidade.Text = "";
            tb_rg.Text = "";
            tb_telefone.Text = "";
            tb_codigo.Text = "";
            tb_cpf.Text = "";
            tb_cidade.Text = "";
            tb_bairro.Text = "";
            tb_rua.Text = "";
            tb_numero.Text = "";

            tb_nome.Enabled = false;
            tb_Email.Enabled = false; ;
            tb_datanascimento.Enabled = false;
            tb_nacionalidade.Enabled = false;
            tb_naturalidade.Enabled = false;
            tb_rg.Enabled = false;
            tb_telefone.Enabled = false;
            tb_codigo.Enabled = false;
            tb_cpf.Enabled = false;
            tb_cidade.Enabled = false;
            tb_bairro.Enabled = false;
            tb_rua.Enabled = false;
            tb_numero.Enabled = false;
        }

        private void bt_ConsularCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente consulCliente = new ConsultarCliente();
            consulCliente.ShowDialog();
        }

        private void bt_AdicinarCliente_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            tb_Email.Enabled = true; ;
            tb_datanascimento.Enabled = true;
            tb_nacionalidade.Enabled = true;
            tb_naturalidade.Enabled = true;
            tb_rg.Enabled = true;
            tb_telefone.Enabled = true;
            tb_codigo.Enabled = true;
            tb_cpf.Enabled = true;
            tb_cidade.Enabled = true;
            tb_bairro.Enabled = true;
            tb_rua.Enabled = true;
            tb_numero.Enabled = true;
        }

        // ATALHOS ========================================================================
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    Cliente cliente = new Cliente();
                    cliente.SetNome(tb_nome.ToString());
                    cliente.SetEmail(tb_Email.ToString());
                    cliente.SetRg(tb_rg.ToString());
                    cliente.SetNacionalidade(tb_nacionalidade.ToString());
                    cliente.SetNaturalidade(tb_naturalidade.ToString());
                    cliente.SetTelefone(tb_telefone.ToString());
                    cliente.SetData_nascimento(tb_datanascimento.ToString());
                    cliente.SetCpf(long.Parse(tb_cpf.Text));
                    cliente.SetCodigo(Convert.ToInt32(tb_codigo.Text));

                    Endereco endereco = new Endereco();
                    endereco.SetCidade(tb_cidade.ToString());
                    endereco.SetBairro(tb_bairro.ToString());
                    endereco.SetLogradouro(tb_rua.ToString());
                    endereco.SetNumero(tb_numero.ToString());

                    cliente.SetEndereco(endereco);

                    ControladorCliente controlCliente = new ControladorCliente();
                    controlCliente.SetCliente(cliente);

                    MessageBox.Show("Produto Cadastrado com Sucesso!", "Confirmação");

                    tb_nome.Text = "";
                    tb_Email.Text = "";
                    tb_datanascimento.Text = "";
                    tb_nacionalidade.Text = "";
                    tb_naturalidade.Text = "";
                    tb_rg.Text = "";
                    tb_telefone.Text = "";
                    tb_codigo.Text = "";
                    tb_cpf.Text = "";
                    tb_cidade.Text = "";
                    tb_bairro.Text = "";
                    tb_rua.Text = "";
                    tb_numero.Text = "";

                    tb_nome.Enabled = false;
                    tb_Email.Enabled = false; ;
                    tb_datanascimento.Enabled = false;
                    tb_nacionalidade.Enabled = false;
                    tb_naturalidade.Enabled = false;
                    tb_rg.Enabled = false;
                    tb_telefone.Enabled = false;
                    tb_codigo.Enabled = false;
                    tb_cpf.Enabled = false;
                    tb_cidade.Enabled = false;
                    tb_bairro.Enabled = false;
                    tb_rua.Enabled = false;
                    tb_numero.Enabled = false;
                    break;

                case Keys.Control | Keys.P:
                    ConsultarCliente consultarCliente = new ConsultarCliente();
                    consultarCliente.ShowDialog();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //================================================================================================

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void lb_codigo_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_telefone_Click(object sender, EventArgs e)
        {

        }

        private void tb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_cpf_Click(object sender, EventArgs e)
        {

        }

        private void tb_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_rg_Click(object sender, EventArgs e)
        {

        }

        private void tb_rg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_datanascimento_Click(object sender, EventArgs e)
        {

        }

        private void tb_datanascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_nacionalidade_Click(object sender, EventArgs e)
        {

        }

        private void tb_nacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_naturalidade_Click(object sender, EventArgs e)
        {

        }

        private void tb_naturalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
