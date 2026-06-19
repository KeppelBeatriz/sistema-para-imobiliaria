using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class ClienteData
    {
        // insere um novo cliente no banco
        public void Inserir(Cliente cliente)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "INSERT INTO Cliente (Nome, Cpf, Telefone, Email, DataNascimento, RendaMensal) " +
                             "VALUES (@Nome, @Cpf, @Telefone, @Email, @DataNascimento, @RendaMensal)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@RendaMensal", cliente.RendaMensal);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Cliente: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // atualiza os dados de um cliente existente
        public void Atualizar(Cliente cliente)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "UPDATE Cliente SET Nome=@Nome, Cpf=@Cpf, Telefone=@Telefone, " +
                             "Email=@Email, DataNascimento=@DataNascimento, RendaMensal=@RendaMensal " +
                             "WHERE IdCliente=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@RendaMensal", cliente.RendaMensal);
                cmd.Parameters.AddWithValue("@Id", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Cliente: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todos os clientes cadastrados
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdCliente, Nome, Cpf, Telefone, Email, DataNascimento, RendaMensal FROM Cliente";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Clientes: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca clientes pelo nome usando LIKE para busca parcial
        public DataTable BuscarPorNome(string nome)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdCliente, Nome, Cpf, Telefone, Email, DataNascimento, RendaMensal " +
                             "FROM Cliente WHERE Nome LIKE @Nome";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Cliente: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // exclui um cliente pelo ID
        public void Excluir(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "DELETE FROM Cliente WHERE IdCliente = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Cliente: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}