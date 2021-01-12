using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Model
{
    public class Endereco
    {
        private String cidade, logradouro, bairro, numero, uf;

        public Endereco()
        {
        }

        public Endereco(string cidade, string logradouro, string bairro, string numero)
        {
            this.cidade = cidade;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.numero = numero;
        }

        public Endereco(string cidade, string logradouro, string bairro, string numero, string uf) : this(cidade, logradouro, bairro, numero)
        {
            this.uf = uf;
        }

        public String GetCidade()
        {
            return this.cidade;
        }
        public void SetCidade(String cidade)
        {
            this.cidade = cidade;
        }
        public String GetLogradouro()
        {
            return this.logradouro;
        }
        public void SetLogradouro(String logradouro)
        {
            this.logradouro = logradouro;
        }
        public String GetBairro()
        {
            return this.bairro;
        }
        public void SetBairro(String bairro)
        {
            this.bairro = bairro;
        }
        public String GetNumero()
        {
            return this.numero;
        }
        public void SetNumero(String numero)
        {
            this.numero = numero;
        }
        public String GetUf()
        {
            return this.uf;
        }
        public void SetUf(String uf)
        {
            this.uf = uf;
        }
    }
}
