namespace domos.models
{
    // endereço é usado pelo imóvel para guardar sua localização
    // separamos em classe própria para organizar melhor os dados
    public class Endereco
    {
        private int idEndereco;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string cep;

        public int IdEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
    }
}