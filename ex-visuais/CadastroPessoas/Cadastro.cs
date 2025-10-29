using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    internal class Cadastro
    {
        static List<Pessoa> listaPessoas = new List<Pessoa>();
        
        public static void CadastrarPessoa(Pessoa newpessoa)
        {
            if (newpessoa != null)
            {
               listaPessoas.Add(newpessoa);
            }
        }

        public static Pessoa PesquisarCPF(string cpf) 
        {
            foreach (Pessoa pessoa in listaPessoas)
            {
                if (pessoa.getCPF() == cpf)
                {
                    return pessoa;
                }
            }
            return null;
        }
         public static bool RemoverPessoa(string cpf)
         {
            foreach (Pessoa pessoa in listaPessoas)
            {
                if (pessoa.getCPF() == cpf)
                {
                    listaPessoas.Remove(pessoa);
                    return true;
                }
            }
            return false;
        }

        public static void EditarPessoa(Pessoa currentpessoa, Pessoa newpessoa)
        {
            if (newpessoa != null)
            {
                currentpessoa.setNome(newpessoa.getNome());
                currentpessoa.setIdade(newpessoa.getIdade());
                currentpessoa.setCPF(newpessoa.getCPF());

                MessageBox.Show("Cadastro editado com sucesso!");
            }
            else
                MessageBox.Show("Erro ao editar o cadastro!");
        }
    }
}
