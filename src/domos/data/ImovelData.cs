using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class ImovelData
    {
        // insere um imóvel de aluguel no banco
        // primeiro insere o endereço, depois o imóvel base, depois os dados de aluguel
        public void InserirAluguel(ImovelAluguel imovel)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sqlEndereco = "INSERT INTO Endereco (Rua, Numero, Bairro, Cidade, Cep) " +
                                     "VALUES (@Rua, @Numero, @Bairro, @Cidade, @Cep)";
                MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao);
                cmdEndereco.Parameters.AddWithValue("@Rua", imovel.Endereco.Rua);
                cmdEndereco.Parameters.AddWithValue("@Numero", imovel.Endereco.Numero);
                cmdEndereco.Parameters.AddWithValue("@Bairro", imovel.Endereco.Bairro);
                cmdEndereco.Parameters.AddWithValue("@Cidade", imovel.Endereco.Cidade);
                cmdEndereco.Parameters.AddWithValue("@Cep", imovel.Endereco.Cep);
                cmdEndereco.ExecuteNonQuery();
                int idEndereco = Convert.ToInt32(cmdEndereco.LastInsertedId);

                string sqlImovel = "INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) " +
                                   "VALUES (@Tipo, @Valor, @Status, @QtdQuartos, @PossuiGaragem, @IdEndereco)";
                MySqlCommand cmdImovel = new MySqlCommand(sqlImovel, conexao);
                cmdImovel.Parameters.AddWithValue("@Tipo", "Aluguel");
                cmdImovel.Parameters.AddWithValue("@Valor", imovel.Valor);
                cmdImovel.Parameters.AddWithValue("@Status", imovel.Status);
                cmdImovel.Parameters.AddWithValue("@QtdQuartos", imovel.QtdQuartos);
                cmdImovel.Parameters.AddWithValue("@PossuiGaragem", imovel.PossuiGaragem);
                cmdImovel.Parameters.AddWithValue("@IdEndereco", idEndereco);
                cmdImovel.ExecuteNonQuery();
                int idImovel = Convert.ToInt32(cmdImovel.LastInsertedId);

                string sqlAluguel = "INSERT INTO ImovelAluguel (IdImovelAluguel, TaxaCondominio, IptuMensal) " +
                                    "VALUES (@Id, @TaxaCondominio, @IptuMensal)";
                MySqlCommand cmdAluguel = new MySqlCommand(sqlAluguel, conexao);
                cmdAluguel.Parameters.AddWithValue("@Id", idImovel);
                cmdAluguel.Parameters.AddWithValue("@TaxaCondominio", imovel.TaxaCondominio);
                cmdAluguel.Parameters.AddWithValue("@IptuMensal", imovel.IptuMensal);
                cmdAluguel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir imóvel de aluguel: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // insere um imóvel de venda no banco
        public void InserirVenda(ImovelVenda imovel)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sqlEndereco = "INSERT INTO Endereco (Rua, Numero, Bairro, Cidade, Cep) " +
                                     "VALUES (@Rua, @Numero, @Bairro, @Cidade, @Cep)";
                MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao);
                cmdEndereco.Parameters.AddWithValue("@Rua", imovel.Endereco.Rua);
                cmdEndereco.Parameters.AddWithValue("@Numero", imovel.Endereco.Numero);
                cmdEndereco.Parameters.AddWithValue("@Bairro", imovel.Endereco.Bairro);
                cmdEndereco.Parameters.AddWithValue("@Cidade", imovel.Endereco.Cidade);
                cmdEndereco.Parameters.AddWithValue("@Cep", imovel.Endereco.Cep);
                cmdEndereco.ExecuteNonQuery();
                int idEndereco = Convert.ToInt32(cmdEndereco.LastInsertedId);

                string sqlImovel = "INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) " +
                                   "VALUES (@Tipo, @Valor, @Status, @QtdQuartos, @PossuiGaragem, @IdEndereco)";
                MySqlCommand cmdImovel = new MySqlCommand(sqlImovel, conexao);
                cmdImovel.Parameters.AddWithValue("@Tipo", "Venda");
                cmdImovel.Parameters.AddWithValue("@Valor", imovel.Valor);
                cmdImovel.Parameters.AddWithValue("@Status", imovel.Status);
                cmdImovel.Parameters.AddWithValue("@QtdQuartos", imovel.QtdQuartos);
                cmdImovel.Parameters.AddWithValue("@PossuiGaragem", imovel.PossuiGaragem);
                cmdImovel.Parameters.AddWithValue("@IdEndereco", idEndereco);
                cmdImovel.ExecuteNonQuery();
                int idImovel = Convert.ToInt32(cmdImovel.LastInsertedId);

                string sqlVenda = "INSERT INTO ImovelVenda (IdImovelVenda, AceitaFinanciamento, ValorEscritura) " +
                                  "VALUES (@Id, @AceitaFinanciamento, @ValorEscritura)";
                MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, conexao);
                cmdVenda.Parameters.AddWithValue("@Id", idImovel);
                cmdVenda.Parameters.AddWithValue("@AceitaFinanciamento", imovel.AceitaFinanciamento);
                cmdVenda.Parameters.AddWithValue("@ValorEscritura", imovel.ValorEscritura);
                cmdVenda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir imóvel de venda: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // atualiza os dados de um imóvel existente
        // detecta o tipo e atualiza a tabela correta (ImovelAluguel ou ImovelVenda)
        public void Atualizar(Imovel imovel)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "UPDATE Imovel SET Valor=@Valor, Status=@Status, QtdQuartos=@QtdQuartos, " +
                             "PossuiGaragem=@PossuiGaragem WHERE IdImovel=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Valor", imovel.Valor);
                cmd.Parameters.AddWithValue("@Status", imovel.Status);
                cmd.Parameters.AddWithValue("@QtdQuartos", imovel.QtdQuartos);
                cmd.Parameters.AddWithValue("@PossuiGaragem", imovel.PossuiGaragem);
                cmd.Parameters.AddWithValue("@Id", imovel.IdImovel);
                cmd.ExecuteNonQuery();

                // atualiza campos específicos de aluguel
                if (imovel is ImovelAluguel)
                {
                    ImovelAluguel aluguel = (ImovelAluguel)imovel;
                    string sqlAluguel = "UPDATE ImovelAluguel SET TaxaCondominio=@Taxa, IptuMensal=@Iptu " +
                                       "WHERE IdImovelAluguel=@Id";
                    MySqlCommand cmdAluguel = new MySqlCommand(sqlAluguel, conexao);
                    cmdAluguel.Parameters.AddWithValue("@Taxa", aluguel.TaxaCondominio);
                    cmdAluguel.Parameters.AddWithValue("@Iptu", aluguel.IptuMensal);
                    cmdAluguel.Parameters.AddWithValue("@Id", imovel.IdImovel);
                    cmdAluguel.ExecuteNonQuery();
                }

                // atualiza campos específicos de venda
                if (imovel is ImovelVenda)
                {
                    ImovelVenda venda = (ImovelVenda)imovel;
                    string sqlVenda = "UPDATE ImovelVenda SET AceitaFinanciamento=@Financiamento, ValorEscritura=@Escritura " +
                                      "WHERE IdImovelVenda=@Id";
                    MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, conexao);
                    cmdVenda.Parameters.AddWithValue("@Financiamento", venda.AceitaFinanciamento);
                    cmdVenda.Parameters.AddWithValue("@Escritura", venda.ValorEscritura);
                    cmdVenda.Parameters.AddWithValue("@Id", imovel.IdImovel);
                    cmdVenda.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Imóvel: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todos os imóveis com endereço e dados específicos de aluguel/venda
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = @"SELECT i.IdImovel, i.Tipo, i.Valor, i.Status, i.QtdQuartos, i.PossuiGaragem,
                               e.Rua, e.Numero, e.Bairro, e.Cidade, e.Cep,
                               ia.TaxaCondominio, ia.IptuMensal,
                               iv.AceitaFinanciamento, iv.ValorEscritura
                               FROM Imovel i
                               INNER JOIN Endereco e ON i.IdEndereco = e.IdEndereco
                               LEFT JOIN ImovelAluguel ia ON i.IdImovel = ia.IdImovelAluguel
                               LEFT JOIN ImovelVenda iv ON i.IdImovel = iv.IdImovelVenda";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Imóveis: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca imóveis por tipo, status, bairro ou cidade
        public DataTable BuscarPorTipo(string busca)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = @"SELECT i.IdImovel, i.Tipo, i.Valor, i.Status, i.QtdQuartos, i.PossuiGaragem,
                               e.Rua, e.Numero, e.Bairro, e.Cidade, e.Cep,
                               ia.TaxaCondominio, ia.IptuMensal,
                               iv.AceitaFinanciamento, iv.ValorEscritura
                               FROM Imovel i
                               INNER JOIN Endereco e ON i.IdEndereco = e.IdEndereco
                               LEFT JOIN ImovelAluguel ia ON i.IdImovel = ia.IdImovelAluguel
                               LEFT JOIN ImovelVenda iv ON i.IdImovel = iv.IdImovelVenda
                               WHERE i.Tipo LIKE @Busca OR i.Status LIKE @Busca
                               OR e.Bairro LIKE @Busca OR e.Cidade LIKE @Busca";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Busca", "%" + busca + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Imóveis: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // exclui um imóvel pelo ID
        // o CASCADE que usamos no banco cuida para apagar ImovelAluguel ou ImovelVenda automaticamente
        public void Excluir(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "DELETE FROM Imovel WHERE IdImovel = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Imóvel: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}