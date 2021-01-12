using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Model
{
    public class Produto
    {
        private int codigo, quantidade_estoque;
        private String descrisao;
        private Double preco_com_desconto, preco_sem_desconto;

        public Produto()
        {
        }

        public Produto(int codigo, int quantidade_estoque, string descrisao, Double preco_com_desconto, Double preco_sem_desconto)
        {
            this.codigo = codigo;
            this.quantidade_estoque = quantidade_estoque;
            this.descrisao = descrisao;
            this.preco_com_desconto = preco_com_desconto;
            this.preco_sem_desconto = preco_sem_desconto;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int GetQuantidade_estoque()
        {
            return this.quantidade_estoque;
        }
        public void SetQuantidade_estoque(int quantidade_estoque)
        {
            this.quantidade_estoque = quantidade_estoque;
        }
        public String GetDescrisao()
        {
            return this.descrisao;
        }
        public void SetDescrisao(String descrisao)
        {
            this.descrisao = descrisao;
        }
        public Double GetPreco_com_desconto()
        {
            return this.preco_com_desconto;
        }
        public void SetPreco_com_desconto(Double preco_com_desconto)
        {
            this.preco_com_desconto = preco_com_desconto;
        }
        public Double GetPreco_sem_desconto()
        {
            return this.preco_sem_desconto;
        }
        public void SetPreco_sem_desconto(Double preco_sem_desconto)
        {
            this.preco_sem_desconto = preco_sem_desconto;
        }

    }

}
