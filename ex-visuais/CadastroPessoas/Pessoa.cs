using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Pessoa
    {
        string Nome;
        int Idade;
        string Cpf;
        public Pessoa()
        {
            string nome = "";
            int idade = 0;
            string cpf = "";
        }

        public string getNome() => Nome;
        public string getCPF() => Cpf;
        public int getIdade() => Idade;

        public void setNome(string nome)
        {
            if (nome != null)
                this.Nome = nome;
        }

        public void setIdade(int idade)
        {
            if (idade > 0)
                this.Idade = idade;
        }

        public void setCPF(string cpf)
        {
            if (cpf != null)
                this.Cpf = cpf;
        }

    }
}
