using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class VisitaData
    {
        // Vânia - lógica do RegistrarVisita() 
        // valida se o imóvel está disponível antes de agendar a visita
        public void Inserir(Visita visita)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                // Vânia - verifica se o imóvel está disponível antes de agendar
                string sqlVerifica = "SELECT Status FROM Imovel WHERE IdImovel = @IdImovel";
                MySqlCommand cmdVerifica = new MySqlCommand(sqlVerifica, conexao);
                cmdVerifica.Parameters.AddWithValue("@IdImovel", visita.IdImovel);
                string status = cmdVerifica.ExecuteScalar().ToString();

                if (status != "Disponivel")
                {
                    throw new Exception("Não é possível agendar visita para imóvel indisponível.");
                }

                string sql = "INSERT INTO Visita (IdCliente, IdCorretor, IdImovel, DataHora, Status, Observacao) " +
                             "VALUES (@IdCliente, @IdCorretor, @IdImovel, @DataHora, @Status, @Observacao)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", visita.IdCliente);
                cmd.Parameters.AddWithValue("@IdCorretor", visita.IdCorretor);
                cmd.Parameters.AddWithValue("@IdImovel", visita.IdImovel);
                cmd.Parameters.AddWithValue("@DataHora", visita.DataHora);
                cmd.Parameters.AddWithValue("@Status", visita.Status);
                cmd.Parameters.AddWithValue("@Observacao", visita.Observacao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao agendar visita: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // atualiza os dados de uma visita existente
        public void Atualizar(Visita visita)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "UPDATE Visita SET IdCliente=@IdCliente, IdCorretor=@IdCorretor, " +
                             "IdImovel=@IdImovel, DataHora=@DataHora, Status=@Status, Observacao=@Observacao " +
                             "WHERE IdVisita=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", visita.IdCliente);
                cmd.Parameters.AddWithValue("@IdCorretor", visita.IdCorretor);
                cmd.Parameters.AddWithValue("@IdImovel", visita.IdImovel);
                cmd.Parameters.AddWithValue("@DataHora", visita.DataHora);
                cmd.Parameters.AddWithValue("@Status", visita.Status);
                cmd.Parameters.AddWithValue("@Observacao", visita.Observacao);
                cmd.Parameters.AddWithValue("@Id", visita.IdVisita);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Visita: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todas as visitas cadastradas
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdVisita, IdCliente, IdCorretor, IdImovel, DataHora, Status, Observacao FROM Visita";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Visitas: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca visitas por ID do cliente ou status
        public DataTable BuscarPorCliente(string busca)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdVisita, IdCliente, IdCorretor, IdImovel, DataHora, Status, Observacao " +
                             "FROM Visita WHERE IdCliente LIKE @Busca OR Status LIKE @Busca";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Busca", "%" + busca + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Visitas: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // exclui uma visita pelo ID
        public void Excluir(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "DELETE FROM Visita WHERE IdVisita = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Visita: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}