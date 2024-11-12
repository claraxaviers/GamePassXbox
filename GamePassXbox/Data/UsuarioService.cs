using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace GamePassXbox.Data
{
    public class UsuarioService
    {
        private readonly IMongoCollection<Usuario> _usuarios;

        public UsuarioService()
        {
            var cliente = new MongoClient("mongodb://localhost:27017"); // Conexão com o MongoDB
            var bancoDeDados = cliente.GetDatabase("XboxDB");
            _usuarios = bancoDeDados.GetCollection<Usuario>("usuarios");
        }

        // Método para adicionar um novo usuário
        public void AdicionarUsuario(string email, string senha)
        {
            var novoUsuario = new Usuario
            {
                Email = email,
                Senha = senha
            };

            _usuarios.InsertOne(novoUsuario);
        }

        // Método para autenticar um usuário
        public bool AutenticarUsuario(string email, string senha)
        {
            var usuario = _usuarios.Find(u => u.Email == email).FirstOrDefault();
            if (usuario != null && usuario.Senha == senha)
            {
                return true;
            }
            return false;

        }

        
    }
}
