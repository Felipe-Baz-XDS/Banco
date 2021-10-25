using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios{
    public class Diretor : FuncionarioAutenticavel{
        public Diretor(string nome, string cpf) : base(nome, cpf, 5000){
        }

        public override double GetBonificacao(){
            return Salario * 0.5;
        }

        public override void AumentarSalario(){
            Salario *= 1.15;
        }
    }
}