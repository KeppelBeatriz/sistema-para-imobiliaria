using System;

namespace domos.models
{
    // imovel é abstrata porque no sistema só existem imóveis de Aluguel ou Venda
    // nunca vamos criar um "imóvel genérico"
    public abstract class Imovel
    {
        private int idImovel;
        private string tipo;
        private double valor;
        private string status;
        private int qtdQuartos;
        private bool possuiGaragem;

        // todo imóvel tem um endereço associado
        public Endereco Endereco = new Endereco();

        public int IdImovel
        {
            get { return idImovel; }
            set { idImovel = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public double Valor
        {
            get { return valor; }
            set
            {
                // Imóvel com valor zero ou negativo não faz sentido
                if (value <= 0)
                    throw new Exception("Valor do imóvel deve ser maior que zero.");
                valor = value;
            }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int QtdQuartos
        {
            get { return qtdQuartos; }
            set
            {
                if (value <= 0)
                    throw new Exception("Quantidade de quartos deve ser maior que zero.");
                qtdQuartos = value;
            }
        }
        public bool PossuiGaragem
        {
            get { return possuiGaragem; }
            set { possuiGaragem = value; }
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine("ID: " + IdImovel);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Valor: R$ " + Valor);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Quartos: " + QtdQuartos);
            Console.WriteLine("Garagem: " + (PossuiGaragem ? "Sim" : "Não"));
        }

        // método abstrato - cada subclasse calcula o valor total do seu jeito
        // polimorfismo - mesma assinatura, comportamentos diferentes
        public abstract double CalcularValorTotal();
    }
}