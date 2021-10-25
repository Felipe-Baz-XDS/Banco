using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        protected FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario){
        }

        public bool Autenticar(string senha){
            return (Senha == senha);
        }
    }
}