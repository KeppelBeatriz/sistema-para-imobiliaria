using System;

namespace domos.models
{
    // ImovelAluguel herda de Imovel e adiciona taxas específicas de locação
    public class ImovelAluguel : Imovel
    {
        private double taxaCondominio;
        private double iptuMensal;

        public double TaxaCondominio
        {
            get { return taxaCondominio; }
            set
            {
                if (value < 0)
                    throw new Exception("Taxa de condomínio não pode ser negativa.");
                taxaCondominio = value;
            }
        }
        public double IptuMensal
        {
            get { return iptuMensal; }
            set
            {
                if (value < 0)
                    throw new Exception("IPTU mensal não pode ser negativo.");
                iptuMensal = value;
            }
        }

        // polimorfismo - calcula o valor total somando aluguel + condomínio + IPTU
        public override double CalcularValorTotal()
        {
            return Valor + TaxaCondominio + IptuMensal;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("----- IMÓVEL ALUGUEL -----");
            base.ExibirDados();
            Console.WriteLine("Taxa Condomínio: R$ " + TaxaCondominio);
            Console.WriteLine("IPTU Mensal: R$ " + IptuMensal);
            Console.WriteLine("Valor Total Mensal: R$ " + CalcularValorTotal());
        }
    }
}