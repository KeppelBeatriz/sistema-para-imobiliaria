using System;

namespace domos.models
{
    // RH também herda de Usuario - é o administrador do sistema
    // tem nível de acesso para controlar o que pode fazer no sistema
    public class RH : Usuario
    {
        private int nivelAcesso;

        public int NivelAcesso
        {
            get { return nivelAcesso; }
            set
            {
                // apenas níveis 1, 2 ou 3 são válidos
                if (value < 1 || value > 3)
                    throw new Exception("Nível de acesso deve ser entre 1 e 3.");
                nivelAcesso = value;
            }
        }

        // polimorfismo - ExibirDados() adaptado para o RH
        public override void ExibirDados()
        {
            Console.WriteLine("----- RH | ADMINISTRADOR -----");
            base.ExibirDados();
            Console.WriteLine("Nível de Acesso: " + NivelAcesso);
        }

        // o RH é quem calcula a comissão dos corretores
        public double CalcularTaxaComissao(int quantidadeVendas, double percentual)
        {
            return quantidadeVendas * percentual;
        }
    }
}