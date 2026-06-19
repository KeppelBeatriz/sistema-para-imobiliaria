using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class PropostaData
    {
        // Vânia - lógica do RegistrarProposta() 
        // Valida imóvel disponível e proposta duplicada antes de inserir
        public void Inserir(Proposta proposta)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                // Vânia - verifica se o imóvel está disponível
                string sqlStatus = "SELECT Status FROM Imovel WHERE IdImovel = @IdImovel";
                MySqlCommand cmdStatus = new MySqlCommand(sqlStatus, conexao);
                cmdStatus.Parameters.AddWithValue("@IdImovel", proposta.IdImovel);
                string status = cmdStatus.ExecuteScalar().ToString();

                if (status != "Disponivel")
                {
                    throw new Exception("Imóvel não está disponível para proposta.");
                }

                // Vânia - verifica se o cliente já tem proposta para esse imóvel
                string sqlDuplicada = "SELECT COUNT(*) FROM Proposta WHERE IdCliente = @IdCliente AND IdImovel = @IdImovel";
                MySqlCommand cmdDuplicada = new MySqlCommand(sqlDuplicada, conexao);
                cmdDuplicada.Parameters.AddWithValue("@IdCliente", proposta.IdCliente);
                cmdDuplicada.Parameters.AddWithValue("@IdImovel", proposta.IdImovel);
                int count = Convert.ToInt32(cmdDuplicada.ExecuteScalar());

                if (count > 0)
                {
                    throw new Exception("Cliente já possui proposta para este imóvel.");
                }

                string sql = "INSERT INTO Proposta (IdCliente, IdImovel, DataProposta, Valor, CondicoesPagamento, Status) " +
                             "VALUES (@IdCliente, @IdImovel, @DataProposta, @Valor, @CondicoesPagamento, @Status)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", proposta.IdCliente);
                cmd.Parameters.AddWithValue("@IdImovel", proposta.IdImovel);
                cmd.Parameters.AddWithValue("@DataProposta", proposta.DataProposta);
                cmd.Parameters.AddWithValue("@Valor", proposta.Valor);
                cmd.Parameters.AddWithValue("@CondicoesPagamento", proposta.CondicoesPagamento);
                cmd.Parameters.AddWithValue("@Status", proposta.Status);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todas as propostas cadastradas
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdProposta, IdCliente, IdImovel, DataProposta, Valor, CondicoesPagamento, Status FROM Proposta";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Propostas: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca propostas pelo status
        public DataTable BuscarPorStatus(string status)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdProposta, IdCliente, IdImovel, DataProposta, Valor, CondicoesPagamento, Status " +
                             "FROM Proposta WHERE Status LIKE @Status";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Status", "%" + status + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Propostas: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // Vânia - lógica do AprovarProposta() 
        // ao aprovar - muda status do imóvel, recusa outras propostas e incrementa vendas do corretor
        public void AtualizarStatus(int idProposta, string novoStatus)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                // atualiza o status da proposta selecionada
                string sqlProposta = "UPDATE Proposta SET Status = @Status WHERE IdProposta = @Id";
                MySqlCommand cmdProposta = new MySqlCommand(sqlProposta, conexao);
                cmdProposta.Parameters.AddWithValue("@Status", novoStatus);
                cmdProposta.Parameters.AddWithValue("@Id", idProposta);
                cmdProposta.ExecuteNonQuery();

                if (novoStatus == "Aceita")
                {
                    // busca o ID do imóvel vinculado a essa proposta
                    string sqlBusca = "SELECT IdImovel FROM Proposta WHERE IdProposta = @Id";
                    MySqlCommand cmdBusca = new MySqlCommand(sqlBusca, conexao);
                    cmdBusca.Parameters.AddWithValue("@Id", idProposta);
                    int idImovel = Convert.ToInt32(cmdBusca.ExecuteScalar());

                    // busca o tipo do imóvel para saber se vira Alugado ou Vendido
                    string sqlTipo = "SELECT Tipo FROM Imovel WHERE IdImovel = @IdImovel";
                    MySqlCommand cmdTipo = new MySqlCommand(sqlTipo, conexao);
                    cmdTipo.Parameters.AddWithValue("@IdImovel", idImovel);
                    string tipo = cmdTipo.ExecuteScalar().ToString();

                    // Vânia - muda status do imóvel conforme o tipo (Aluguel ou Venda)
                    string statusImovel = tipo == "Aluguel" ? "Alugado" : "Vendido";
                    string sqlImovel = "UPDATE Imovel SET Status = @Status WHERE IdImovel = @IdImovel";
                    MySqlCommand cmdImovel = new MySqlCommand(sqlImovel, conexao);
                    cmdImovel.Parameters.AddWithValue("@Status", statusImovel);
                    cmdImovel.Parameters.AddWithValue("@IdImovel", idImovel);
                    cmdImovel.ExecuteNonQuery();

                    // Vânia - incrementa QuantidadeVendas do corretor vinculado ao imóvel
                    string sqlCorretor = "UPDATE Corretor c " +
                                        "INNER JOIN CorretorImovel ci ON ci.IdCorretor = c.IdCorretor " +
                                        "SET c.QuantidadeVendas = c.QuantidadeVendas + 1 " +
                                        "WHERE ci.IdImovel = @IdImovel";
                    MySqlCommand cmdCorretor = new MySqlCommand(sqlCorretor, conexao);
                    cmdCorretor.Parameters.AddWithValue("@IdImovel", idImovel);
                    cmdCorretor.ExecuteNonQuery();

                    // Recusa automaticamente as outras propostas pendentes do mesmo imóvel
                    string sqlRecusa = "UPDATE Proposta SET Status = 'Recusada' " +
                                      "WHERE IdImovel = @IdImovel AND Status = 'Pendente' AND IdProposta != @IdProposta";
                    MySqlCommand cmdRecusa = new MySqlCommand(sqlRecusa, conexao);
                    cmdRecusa.Parameters.AddWithValue("@IdImovel", idImovel);
                    cmdRecusa.Parameters.AddWithValue("@IdProposta", idProposta);
                    cmdRecusa.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar proposta: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // conta propostas por status para o relatório
        public int ContarPorStatus(string status)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return 0;

            try
            {
                string sql = "SELECT COUNT(*) FROM Proposta WHERE Status = @Status";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Status", status);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao contar Propostas: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}