using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class CorretorData
    {
        // faz o login do corretor verificando email e senha no banco
        public Corretor Login(string email, string senha)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT * FROM Corretor WHERE Email = @Email AND Senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Corretor corretor = new Corretor();
                    corretor.Id = Convert.ToInt32(reader["IdCorretor"]);
                    corretor.Nome = reader["Nome"].ToString();
                    corretor.Cpf = reader["Cpf"].ToString();
                    corretor.Telefone = reader["Telefone"].ToString();
                    corretor.Email = reader["Email"].ToString();
                    corretor.Senha = reader["Senha"].ToString();
                    corretor.Creci = reader["Creci"].ToString();
                    corretor.TaxaComissao = Convert.ToDouble(reader["TaxaComissao"]);
                    corretor.QuantidadeVendas = Convert.ToInt32(reader["QuantidadeVendas"]);
                    return corretor;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no login Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // insere um novo corretor no banco
        public void Inserir(Corretor corretor)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "INSERT INTO Corretor (Nome, Cpf, Telefone, Email, Senha, Creci, TaxaComissao, QuantidadeVendas) " +
                             "VALUES (@Nome, @Cpf, @Telefone, @Email, @Senha, @Creci, @TaxaComissao, @QuantidadeVendas)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", corretor.Nome);
                cmd.Parameters.AddWithValue("@Cpf", corretor.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", corretor.Telefone);
                cmd.Parameters.AddWithValue("@Email", corretor.Email);
                cmd.Parameters.AddWithValue("@Senha", corretor.Senha);
                cmd.Parameters.AddWithValue("@Creci", corretor.Creci);
                cmd.Parameters.AddWithValue("@TaxaComissao", corretor.TaxaComissao);
                cmd.Parameters.AddWithValue("@QuantidadeVendas", corretor.QuantidadeVendas);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // atualiza os dados de um corretor existente
        public void Atualizar(Corretor corretor)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "UPDATE Corretor SET Nome=@Nome, Cpf=@Cpf, Telefone=@Telefone, " +
                             "Email=@Email, Senha=@Senha, Creci=@Creci, TaxaComissao=@TaxaComissao " +
                             "WHERE IdCorretor=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", corretor.Nome);
                cmd.Parameters.AddWithValue("@Cpf", corretor.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", corretor.Telefone);
                cmd.Parameters.AddWithValue("@Email", corretor.Email);
                cmd.Parameters.AddWithValue("@Senha", corretor.Senha);
                cmd.Parameters.AddWithValue("@Creci", corretor.Creci);
                cmd.Parameters.AddWithValue("@TaxaComissao", corretor.TaxaComissao);
                cmd.Parameters.AddWithValue("@Id", corretor.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todos os corretores cadastrados
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdCorretor, Nome, Cpf, Telefone, Email, Creci, TaxaComissao, QuantidadeVendas FROM Corretor";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Corretores: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca corretores pelo nome usando LIKE para busca parcial
        public DataTable BuscarPorNome(string nome)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdCorretor, Nome, Cpf, Telefone, Email, Creci, TaxaComissao, QuantidadeVendas " +
                             "FROM Corretor WHERE Nome LIKE @Nome";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // Vânia - lógica de BuscarCorretor() 
        // Busca um corretor específico pelo ID
        public Corretor BuscarPorId(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT * FROM Corretor WHERE IdCorretor = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Corretor corretor = new Corretor();
                    corretor.Id = Convert.ToInt32(reader["IdCorretor"]);
                    corretor.Nome = reader["Nome"].ToString();
                    corretor.Cpf = reader["Cpf"].ToString();
                    corretor.Telefone = reader["Telefone"].ToString();
                    corretor.Email = reader["Email"].ToString();
                    corretor.Creci = reader["Creci"].ToString();
                    corretor.TaxaComissao = Convert.ToDouble(reader["TaxaComissao"]);
                    corretor.QuantidadeVendas = Convert.ToInt32(reader["QuantidadeVendas"]);
                    return corretor;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // exclui um corretor pelo ID
        public void Excluir(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "DELETE FROM Corretor WHERE IdCorretor = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Corretor: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}