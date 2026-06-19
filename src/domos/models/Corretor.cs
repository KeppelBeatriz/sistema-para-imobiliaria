using System;

namespace domos.models
{
    // corretor herda de Usuario - herança aplicada aqui
    public class Corretor : Usuario
    {
        private string creci;
        private double taxaComissao;
        private int quantidadeVendas;

        public string Creci
        {
            get { return creci; }
            set { creci = value; }
        }
        public double TaxaComissao
        {
            get { return taxaComissao; }
            set
            {
                // comissão tem que estar entre 0 e 100%
                if (value < 0 || value > 100)
                    throw new Exception("Taxa de comissão deve estar entre 0 e 100.");
                taxaComissao = value;
            }
        }
        public int QuantidadeVendas
        {
            get { return quantidadeVendas; }
            set
            {
                // exception em casos de vendas negativas pq não faz sentido vendas negativas
                if (value < 0)
                    throw new Exception("Quantidade de vendas não pode ser negativa.");
                quantidadeVendas = value;
            }
        }

        // Polimorfismo: sobrescrevemos ExibirDados() para mostrar os dados do corretor
        public override void ExibirDados()
        {
            Console.WriteLine("----- CORRETOR -----");
            base.ExibirDados(); // Aproveita o método da classe pai
            Console.WriteLine("CRECI: " + Creci);
            Console.WriteLine("Taxa de Comissão: " + TaxaComissao + "%");
            Console.WriteLine("Quantidade de Vendas: " + QuantidadeVendas);
        }

        // calcula quanto o corretor vai receber de comissão por uma venda
        public double CalcularComissao(double valorVenda)
        {
            return valorVenda * (TaxaComissao / 100);
        }
    }
}