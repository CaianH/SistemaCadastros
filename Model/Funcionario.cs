using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettware_poo.Model
{
    public class Funcionario
    {
        private long cpf;
        private int codigo;
        private String nome, telefone, data_nascimento, rg, nacionalidade, naturalidade, email;
        private Endereco endereco;

        public Funcionario()
        {
        }

        public Funcionario(int codigo, long cpf, string nome, string telefone, string data_nascimento, string rg, string nacionalidade, string naturalidade, string email, Endereco endereco)
        {
            this.codigo = codigo;
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
            this.data_nascimento = data_nascimento;
            this.rg = rg;
            this.nacionalidade = nacionalidade;
            this.naturalidade = naturalidade;
            this.email = email;
            this.endereco = endereco;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public long GetCpf()
        {
            return this.cpf;
        }
        public void SetCpf(long cpf)
        {
            this.cpf = cpf;
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
        public String GetData_nascimento()
        {
            return this.data_nascimento;
        }
        public void SetData_nascimento(String data_nascimento)
        {
            this.data_nascimento = data_nascimento;
        }
        public String GetRg()
        {
            return this.rg;
        }
        public void SetRg(String rg)
        {
            this.rg = rg;
        }
        public String GetNacionalidade()
        {
            return this.nacionalidade;
        }
        public void SetNacionalidade(String nacionalidade)
        {
            this.nacionalidade = nacionalidade;
        }
        public String GetNaturalidade()
        {
            return this.naturalidade;
        }
        public void SetNaturalidade(String naturalidade)
        {
            this.naturalidade = naturalidade;
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
