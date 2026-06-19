using System;

namespace domos.models
{
    // proposta é enviada por um cliente para um imóvel específico
    // uma proposta aceita muda o status do imóvel automaticamente
    public class Proposta
    {
        private int idProposta;
        private int idCliente;
        private int idImovel;
        private DateTime dataProposta;
        private double valor;
        private string condicoesPagamento;
        private string status;

        public int IdProposta
        {
            get { return idProposta; }
            set { idProposta = value; }
        }
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int IdImovel
        {
            get { return idImovel; }
            set { idImovel = value; }
        }
        public DateTime DataProposta
        {
            get { return dataProposta; }
            set { dataProposta = value; }
        }
        public double Valor
        {
            get { return valor; }
            set
            {
                // proposta com valor zero ou negativo não é válida
                if (value <= 0)
                    throw new Exception("Valor da proposta deve ser maior que zero.");
                valor = value;
            }
        }
        public string CondicoesPagamento
        {
            get { return condicoesPagamento; }
            set { condicoesPagamento = value; }
        }
        public string Status
        {
            get { return status; }
            // mesmo caso o status só pode ser Pendente, Aceita ou Recusada
            set { status = value; }
        }
    }
}