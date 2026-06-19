using System;

namespace domos.models
{
    // classe abstrata que serve como base para Corretor e RH
    // não temos usuário genérico no sistema, por isso usamos abstrata
    public abstract class Usuario
    {
        // atributos privados - encapsulamento para proteger os dados
        private int id;
        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private string senha;

        // propriedades para acessar os atributos com segurança
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                // validação - nome não pode ser vazio
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome não pode ser vazio.");
                nome = value;
            }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        // método virtual - pode ser sobrescrito nas subclasses (polimorfismo)
        public virtual void ExibirDados()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
        }
    }
}