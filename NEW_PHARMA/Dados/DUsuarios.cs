using System;
using System.Data;
using System.Text;
using Dados;
using Microsoft.Data.SqlClient;
using Modelo;
using Xceed.Wpf.Toolkit;
using XSystem.Security.Cryptography;

namespace Dados
{
    public class DUsuario
    {
        private DadosConexao conexao;

        public DUsuario(DadosConexao dadosConexao)
        {
            this.conexao = dadosConexao;
        }

        public bool Inserir(ModeloUsuarios.Usuario usuario)
        {
            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbUsuario (Nome, Login, SenhaHash, NivelAcesso, Ativo) " +
                                      "VALUES (@Nome, @Login, @SenhaHash, @NivelAcesso, @Ativo)";
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso);
                    cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);

                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o usuário: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public ModeloUsuarios.Usuario BuscarPorLogin(string login)
        {
            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "SELECT * FROM tbUsuario WHERE Login = @Login AND Ativo = 1";
                    cmd.Parameters.AddWithValue("@Login", login);

                    conexao.AbrirConexao();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ModeloUsuarios.Usuario
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Nome = reader["Nome"].ToString(),
                                Login = reader["Login"].ToString(),
                                SenhaHash = reader["SenhaHash"].ToString(),
                                NivelAcesso = Convert.ToInt32(reader["NivelAcesso"]),
                                Ativo = Convert.ToBoolean(reader["Ativo"])
                            };
                        }
                        return null; // Usuário não encontrado
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public bool ValidarSenhaAdministrador(string senha)
        {
            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "SELECT SenhaHash FROM tbUsuario WHERE NivelAcesso = @NivelAcesso AND Ativo = 1";
                    cmd.Parameters.AddWithValue("@NivelAcesso", (int)Modelo.NivelAcesso.Administrador);

                    conexao.AbrirConexao();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string senhaHash = reader["SenhaHash"].ToString();
                            return VerificarSenha(senha, senhaHash);
                        }
                        else
                        {
                            throw new Exception("Administrador não encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar a senha do administrador: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private bool VerificarSenha(string senhaFornecida, string senhaHash)
        {
            // Usar o mesmo algoritmo de hash para comparar as senhas
            using (var sha256 = new SHA256Managed())
            {
                byte[] senhaBytes = Encoding.UTF8.GetBytes(senhaFornecida);
                byte[] hashComputado = sha256.ComputeHash(senhaBytes);

                string senhaComputadaHash = Convert.ToBase64String(hashComputado);
                return senhaComputadaHash == senhaHash;
            }
        }


        public bool ValidarNivelAcesso(int nivelAcesso, string senhaAdministrador)
        {
            // Se o nível de acesso for Administrador ou Gestor, valida a senha do administrador
            if (nivelAcesso == (int)Modelo.NivelAcesso.Administrador || nivelAcesso == (int)Modelo.NivelAcesso.Gestor)
            {
                return ValidarSenhaAdministrador(senhaAdministrador);
            }
            return true; // Para outros níveis de acesso, a validação é automática
        }


        public bool ValidarCredenciais(string login, string senhaHash)
        {
            try
            {
                using (var connection = new SqlConnection(new DadosConexao(DConexao.StringConexao).ObjectoConexao.ConnectionString))
                {
                    string query = @"
                    SELECT COUNT(1) 
                    FROM tbUsuario 
                    WHERE Login = @Login AND SenhaHash = @SenhaHash AND Ativo = 1";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@SenhaHash", senhaHash);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar credenciais: " + ex.Message);
            }

        }

        public bool ValidarSenhaAdministradorPrincipal(string senha)
        {
            try
            {
                using (var connection = new SqlConnection(new DadosConexao(DConexao.StringConexao).ObjectoConexao.ConnectionString))
                {
                    string query = "SELECT COUNT(1) FROM tbUsuario WHERE NivelAcesso = @NivelAcesso AND SenhaHash = @SenhaHash AND Ativo = 1";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NivelAcesso", "Administrador");
                        command.Parameters.AddWithValue("@SenhaHash", GerarHashSenha(senha));

                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar a senha do administrador: " + ex.Message);
            }
        }

        private string GerarHashSenha(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(senha);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }


    }
}
