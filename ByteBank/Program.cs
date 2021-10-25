using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank{
    class Program{
        static void Main(string[] args){
            GerenciadorBonificação gerenciador = new GerenciadorBonificação();

            Designer felipe = new Designer("Felipe Baz Mitsuishi","489.109.394-41");
            Diretor bruno = new Diretor("bruno","429.129.324-23");
            GerenteDeConta rogerio = new GerenteDeConta("Rogerio", "654.994.456-45");
            Auxiliar ana = new Auxiliar("Ana", "234.454.332-54");
            Desenvolvedor joao = new Desenvolvedor("joao", "234.444.222-54");
            
            gerenciador.Registrar(felipe);
            gerenciador.Registrar(bruno);
            gerenciador.Registrar(rogerio);
            gerenciador.Registrar(ana);
            gerenciador.Registrar(joao);

            Console.WriteLine(gerenciador.GetBonificacao());

            felipe.AumentarSalario();
            Console.WriteLine("o novo salario do " + felipe.Nome + " é R$ " + felipe.Salario);

            bruno.AumentarSalario();
            Console.WriteLine(bruno.Salario);
            Console.WriteLine("o novo salario do " + bruno.Nome + " é R$ " + bruno.Salario);

            UsarSistema();
        }

        public static void UsarSistema(){
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor bruno = new Diretor("bruno","429.129.324-23");
            bruno.Senha = "123";
            GerenteDeConta rogerio = new GerenteDeConta("Rogerio", "654.994.456-45");
            rogerio.Senha = "abc";

            sistemaInterno.Logar(bruno, "1234");
            sistemaInterno.Logar(bruno, "123");
            sistemaInterno.Logar(rogerio, "1234");
            sistemaInterno.Logar(rogerio, "abc");
        }
    }
}
