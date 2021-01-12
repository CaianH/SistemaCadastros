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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                

                tb_Codigo.Enabled = true;
                tb_Descrisao.Enabled = true;
                tb_PrecoComDesconto.Enabled = true;
                tb_PrecoSemDesconto.Enabled = true;
                tb_QuantidadeEmEstoque.Enabled = true;

  
           
            
            
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lb_Codigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_QuantidadeEmEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_SelecionarFoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Perfil.ImageLocation = openFileDialog1.FileName;
                pb_Perfil.Load();
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Perfil.ImageLocation = openFileDialog1.FileName;
                pb_Perfil.Load();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void CadProduto_Load(object sender, EventArgs e)
        {

        }

        private void bt_ConsularProduto_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultarpro = new ConsultarProduto();
            consultarpro.ShowDialog();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
          

                Produto produto = new Produto();

                produto.SetDescrisao(tb_Descrisao.ToString());
                produto.SetCodigo(Convert.ToInt32(tb_Codigo.Text));
                
                produto.SetPreco_com_desconto(Convert.ToDouble(tb_PrecoComDesconto.Text));
                produto.SetPreco_sem_desconto(Convert.ToDouble(tb_PrecoSemDesconto.Text));
                produto.SetQuantidade_estoque(Convert.ToInt32(tb_QuantidadeEmEstoque.Text));

                ControladorProduto controladorpro = new ControladorProduto();
                controladorpro.SetProduto(produto);

                MessageBox.Show("Produto Cadastrado com Sucesso!", "Confirmação");

                tb_Codigo.Text = "";
                tb_Descrisao.Text = "";
                tb_PrecoComDesconto.Text = "";
                tb_PrecoSemDesconto.Text = "";
                tb_QuantidadeEmEstoque.Text = "";

                tb_Codigo.Enabled = false;
                tb_Descrisao.Enabled = false;
                tb_PrecoComDesconto.Enabled = false;
                tb_PrecoSemDesconto.Enabled = false;
                tb_QuantidadeEmEstoque.Enabled = false;
            
           
        }

        //ATALHOS=====================================================================
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Control | Keys.S:

                    Produto produto = new Produto();
                    produto.SetDescrisao(tb_Descrisao.ToString());
                    produto.SetCodigo(Convert.ToInt32(tb_Codigo.Text));
                    produto.SetPreco_com_desconto(Convert.ToDouble(tb_PrecoComDesconto.Text));
                    produto.SetPreco_sem_desconto(Convert.ToDouble(tb_PrecoSemDesconto.Text));
                    produto.SetQuantidade_estoque(Convert.ToInt32(tb_QuantidadeEmEstoque.Text));

                    ControladorProduto controladorpro = new ControladorProduto();
                    controladorpro.SetProduto(produto);

                    MessageBox.Show("Produto Cadastrado com Sucesso!", "Confirmação");

                    tb_Codigo.Text = "";
                    tb_Descrisao.Text = "";
                    tb_PrecoComDesconto.Text = "";
                    tb_PrecoSemDesconto.Text = "";
                    tb_QuantidadeEmEstoque.Text = "";

                    tb_Codigo.Enabled = false;
                    tb_Descrisao.Enabled = false;
                    tb_PrecoComDesconto.Enabled = false;
                    tb_PrecoSemDesconto.Enabled = false;
                    tb_QuantidadeEmEstoque.Enabled = false;
                    break;

                case Keys.Control | Keys.P:
                    ConsultarProduto consultarProduto = new ConsultarProduto();
                    consultarProduto.ShowDialog();

                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //======================================================================================

        private void bt_Cancelar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bt_Salvar_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void bt_Salvar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bt_Salvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || Keys.Control == Keys.S)
            {
            }
        }
    }
}
