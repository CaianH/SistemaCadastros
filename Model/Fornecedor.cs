using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Model
{
    public class Fornecedor
    {
        private String cnpj, nome, telefone, email;
        private Endereco endereco;

        public Fornecedor()
        {
        }

        public Fornecedor(string cnpj, string nome, string telefone, string email, Endereco endereco)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.endereco = endereco;
        }

        public String GetCnpj()
        {
            return this.cnpj;
        }
        public void SetCnpj(String cnpj)
        {
            this.cnpj = cnpj;
        }
        public String GetNome()
        {
            return this.nome;
        }
        public void SetNome(String nome)
        {
            this.nome = nome;
        }
        public String GetTelefone()
        {
            return this.telefone;
        }
        public void SetTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String GetEmail()
        {
            return this.email;
        }
        public void SetEmail(String email)
        {
            this.email = email;
        }
        public Endereco GetEndereco()
        {
            return this.endereco;
        }
        public void SetEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }
    }
}
