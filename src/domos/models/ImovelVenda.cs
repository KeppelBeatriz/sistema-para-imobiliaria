using System;

namespace domos.models
{
    // ImovelVenda herda de Imovel e adiciona custos específicos de compra
    public class ImovelVenda : Imovel
    {
        private bool aceitaFinanciamento;
        private double valorEscritura;

        public bool AceitaFinanciamento
        {
            get { return aceitaFinanciamento; }
            set { aceitaFinanciamento = value; }
        }
        public double ValorEscritura
        {
            get { return valorEscritura; }
            set
            {
                if (value < 0)
                    throw new Exception("Valor de escritura não pode ser negativo.");
                valorEscritura = value;
            }
        }

        // polimorfismo - calcula valor total somando preço do imóvel + escritura
        public override double CalcularValorTotal()
        {
            return Valor + ValorEscritura;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("----- IMÓVEL VENDA -----");
            base.ExibirDados();
            Console.WriteLine("Aceita Financiamento: " + (AceitaFinanciamento ? "Sim" : "Não"));
            Console.WriteLine("Valor Escritura: R$ " + ValorEscritura);
            Console.WriteLine("Valor Total: R$ " + CalcularValorTotal());
        }
    }
}