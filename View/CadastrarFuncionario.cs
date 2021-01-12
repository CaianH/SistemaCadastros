using Pettware_poo.Controller;
using Pettware_poo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pettware_poo.View
{
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void pb_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Perfil.ImageLocation = openFileDialog1.FileName;
                pb_Perfil.Load();

            }
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

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

        private void bt_ConsularCliente_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario consltFuncionario = new ConsultarFuncionario();
            consltFuncionario.ShowDialog();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            Funcionario funcionario = new Funcionario();

            funcionario.SetNome(tb_nome.ToString());
            funcionario.SetEmail(tb_Email.ToString());
            funcionario.SetRg(tb_rg.ToString());
            funcionario.SetNacionalidade(tb_nacionalidade.ToString());
            funcionario.SetNaturalidade(tb_naturalidade.ToString());
            funcionario.SetTelefone(tb_telefone.ToString());
            funcionario.SetData_nascimento(tb_datanascimento.ToString());
            funcionario.SetCpf(long.Parse(tb_cpf.Text));
            funcionario.SetCodigo(Convert.ToInt32(tb_codigo.Text));

            Endereco endereco = new Endereco();

            endereco.SetCidade(tb_cidade.ToString());
            endereco.SetBairro(tb_bairro.ToString());
            endereco.SetLogradouro(tb_rua.ToString());
            endereco.SetNumero(tb_numero.ToString());

            funcionario.SetEndereco(endereco);

            ControladorFuncionario controlFuncionario = new ControladorFuncionario();
            controlFuncionario.SetFuncionario(funcionario);

            MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Confirmação");

            

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

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    Funcionario funcionario = new Funcionario();
                    funcionario.SetNome(tb_nome.ToString());
                    funcionario.SetEmail(tb_Email.ToString());
                    funcionario.SetRg(tb_rg.ToString());
                    funcionario.SetNacionalidade(tb_nacionalidade.ToString());
                    funcionario.SetNaturalidade(tb_naturalidade.ToString());
                    funcionario.SetTelefone(tb_telefone.ToString());
                    funcionario.SetData_nascimento(tb_datanascimento.ToString());
                    funcionario.SetCpf(long.Parse(tb_cpf.Text));
                    funcionario.SetCodigo(Convert.ToInt32(tb_codigo.Text));

                    Endereco endereco = new Endereco();
                    endereco.SetCidade(tb_cidade.ToString());
                    endereco.SetBairro(tb_bairro.ToString());
                    endereco.SetLogradouro(tb_rua.ToString());
                    endereco.SetNumero(tb_numero.ToString());

                    funcionario.SetEndereco(endereco);

                    ControladorFuncionario controlFuncionario = new ControladorFuncionario();
                    controlFuncionario.SetFuncionario(funcionario);

                    MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Confirmação");

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
                    ConsultarFuncionario consltFuncionario = new ConsultarFuncionario();
                    consltFuncionario.ShowDialog();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lb_telefone_Click(object sender, EventArgs e)
        {

        }
    }
}
