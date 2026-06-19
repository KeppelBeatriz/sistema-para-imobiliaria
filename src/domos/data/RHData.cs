using System;
using System.Data;
using MySql.Data.MySqlClient;
using domos.models;
using domos.db;

namespace domos.data
{
    public class RHData
    {
        // faz o login do RH verificando email e senha no banco
        public RH Login(string email, string senha)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT * FROM RH WHERE Email = @Email AND Senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    RH rh = new RH();
                    rh.Id = Convert.ToInt32(reader["IdRH"]);
                    rh.Nome = reader["Nome"].ToString();
                    rh.Cpf = reader["Cpf"].ToString();
                    rh.Telefone = reader["Telefone"].ToString();
                    rh.Email = reader["Email"].ToString();
                    rh.Senha = reader["Senha"].ToString();
                    rh.NivelAcesso = Convert.ToInt32(reader["NivelAcesso"]);
                    return rh;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no login RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // insere um novo RH no banco
        public void Inserir(RH rh)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "INSERT INTO RH (Nome, Cpf, Telefone, Email, Senha, NivelAcesso) " +
                             "VALUES (@Nome, @Cpf, @Telefone, @Email, @Senha, @NivelAcesso)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", rh.Nome);
                cmd.Parameters.AddWithValue("@Cpf", rh.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", rh.Telefone);
                cmd.Parameters.AddWithValue("@Email", rh.Email);
                cmd.Parameters.AddWithValue("@Senha", rh.Senha);
                cmd.Parameters.AddWithValue("@NivelAcesso", rh.NivelAcesso);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // atualiza os dados de um RH existente
        public void Atualizar(RH rh)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "UPDATE RH SET Nome=@Nome, Cpf=@Cpf, Telefone=@Telefone, " +
                             "Email=@Email, Senha=@Senha, NivelAcesso=@NivelAcesso " +
                             "WHERE IdRH=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", rh.Nome);
                cmd.Parameters.AddWithValue("@Cpf", rh.Cpf);
                cmd.Parameters.AddWithValue("@Telefone", rh.Telefone);
                cmd.Parameters.AddWithValue("@Email", rh.Email);
                cmd.Parameters.AddWithValue("@Senha", rh.Senha);
                cmd.Parameters.AddWithValue("@NivelAcesso", rh.NivelAcesso);
                cmd.Parameters.AddWithValue("@Id", rh.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // lista todos os RHs cadastrados
        public DataTable Listar()
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdRH, Nome, Cpf, Telefone, Email, NivelAcesso FROM RH";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // busca RH pelo nome usando LIKE para busca parcial
        public DataTable BuscarPorNome(string nome)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return null;

            try
            {
                string sql = "SELECT IdRH, Nome, Cpf, Telefone, Email, NivelAcesso FROM RH WHERE Nome LIKE @Nome";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }

        // exclui um RH pelo ID
        public void Excluir(int id)
        {
            MySqlConnection conexao = db_imobiliaria.AbrirConexao();
            if (conexao == null) return;

            try
            {
                string sql = "DELETE FROM RH WHERE IdRH = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir RH: " + ex.Message);
            }
            finally
            {
                db_imobiliaria.FecharConexao(conexao);
            }
        }
    }
}