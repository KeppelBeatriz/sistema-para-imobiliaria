using System;
using MySql.Data.MySqlClient;

namespace domos.db
{
    // classe responsável por gerenciar a conexão com o banco de dados MySQL
    public class db_imobiliaria
    {
        // dados de conexão com o banco
        private static string servidor = "localhost";
        private static string banco = "imobiliaria";
        private static string usuario = "root";
        private static string senha = "1234";

        // monta a string de conexão com os dados acima
        private static string StringConexao()
        {
            return "Server=" + servidor + ";Database=" + banco + ";Uid=" + usuario + ";Pwd=" + senha + ";";
        }

        // abre e retorna a conexão com o banco
        // se der erro, mostra a mensagem e retorna null
        public static MySqlConnection AbrirConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StringConexao());
            try
            {
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar com o banco: " + ex.Message);
                return null;
            }
        }

        // fecha a conexão com segurança
        // verifica se ela está aberta antes de tentar fechar
        public static void FecharConexao(MySqlConnection conexao)
        {
            try
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }
    }
}