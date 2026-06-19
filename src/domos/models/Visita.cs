using System;

namespace domos.models
{
    // visita vai conectar um cliente, um corretor e um imóvel em uma data específica
    public class Visita
    {
        private int idVisita;
        private int idCliente;
        private int idCorretor;
        private int idImovel;
        private DateTime dataHora;
        private string status;
        private string observacao;

        public int IdVisita
        {
            get { return idVisita; }
            set { idVisita = value; }
        }
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int IdCorretor
        {
            get { return idCorretor; }
            set { idCorretor = value; }
        }
        public int IdImovel
        {
            get { return idImovel; }
            set { idImovel = value; }
        }
        public DateTime DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
        public string Status
        {
            get { return status; }
            // status só vai pode ser Agendada, Confirmada ou Cancelada
            set { status = value; }
        }
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}