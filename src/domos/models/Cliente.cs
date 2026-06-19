using System;

namespace domos.models
{
    // não colocamos o cliente como usuario pois não acessa o sistema ele apenas participa de visitas e propostas
    public class Cliente
    {
        private int idCliente;
        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private DateTime dataNascimento;
        private double rendaMensal;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
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
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                // data de nascimento não pode ser no futuro
                if (value > DateTime.Today)
                    throw new Exception("Data de nascimento inválida.");
                dataNascimento = value;
            }
        }
        public double RendaMensal
        {
            get { return rendaMensal; }
            set
            {
                // renda não pode ser negativa
                if (value < 0)
                    throw new Exception("Renda mensal não pode ser negativa.");
                rendaMensal = value;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("----- CLIENTE -----");
            Console.WriteLine("ID: " + IdCliente);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Nascimento: " + DataNascimento.ToShortDateString());
            Console.WriteLine("Renda Mensal: R$ " + RendaMensal);
        }
    }
}