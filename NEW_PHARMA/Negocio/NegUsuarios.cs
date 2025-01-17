using Dados;
using Modelo;
using System.Security.Cryptography;
using System.Text;

namespace Negocio
{
    public class NegUsuario
    {
        private DUsuario dUsuario;

        public NegUsuario(DadosConexao conexao)
        {
            dUsuario = new DUsuario(conexao); // Inicia a camada de dados
        }

        // Valida o login e a senha de um usuário
        public bool ValidarLoginSenha(string login, string senha)
        {
            var usuario = dUsuario.BuscarPorLogin(login);
            if (usuario == null)
                return false;

            // Aqui você pode comparar a senha com o hash armazenado (exemplo básico de validação)
            return VerificarSenha(senha, usuario.SenhaHash);
        }

        private bool VerificarSenha(string senha, string senhaHash)
        {
            // Adicione a lógica de verificação do hash da senha, por exemplo, usando uma comparação de hash
            return senha == senhaHash; // Aqui é uma simplificação, use uma função de hash adequada
        }

        // Valida e insere um novo usuário
        public bool AdicionarUsuario(ModeloUsuarios.Usuario usuario)
        {
            if (ValidarUsuario(usuario))
            {
                return dUsuario.Inserir(usuario);
            }
            return false;
        }

        // Valida as propriedades do usuário antes de inserir
        private bool ValidarUsuario(ModeloUsuarios.Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Login))
                return false;

            if (usuario.NivelAcesso < 1 || usuario.NivelAcesso > 3) // Exemplo de validação de níveis de acesso
                return false;

            return true;
        }

        public string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte byteValue in bytes)
                {
                    builder.Append(byteValue.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool ValidarNivelAcesso(int nivelAcesso, string senhaAdministrador = null)
        {
            if (nivelAcesso == (int)NivelAcesso.Gestor || nivelAcesso == (int)NivelAcesso.Administrador)
            {
                if (string.IsNullOrWhiteSpace(senhaAdministrador))
                {
                    throw new Exception("A senha do administrador é obrigatória para esse nível de acesso.");
                }

                return dUsuario.ValidarSenhaAdministrador(senhaAdministrador);
            }

            return true; // Para níveis que não exigem validação
        }

        public bool ValidarSenhaAdministradorPrincipal(string senhaInserida)
        {
            var adminPrincipal = dUsuario.BuscarPorLogin("mt@newpharma"); // Supondo que o login do Admin Principal é "admin"
            if (adminPrincipal != null)
            {
                string hashSenhaInserida = GerarHashSenha(senhaInserida);
                return hashSenhaInserida == adminPrincipal.SenhaHash;
            }
            return false;
        }

        public bool AutenticarUsuario(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Login e senha são obrigatórios.");

            string senhaHash = GerarHashSenha(senha);
            return dUsuario.ValidarCredenciais(login, senhaHash);
        }


        public bool ValidarCredenciais(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Login e senha são obrigatórios.");

            string senhaHash = GerarHashSenha(senha); // Gera o hash da senha fornecida
            return dUsuario.ValidarCredenciais(login, senhaHash); // Chama a camada de dados para validar
        }

    }
}
