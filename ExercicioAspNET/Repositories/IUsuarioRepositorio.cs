using ExercicioAspNET.Models;

namespace ExercicioAspNET.Repositories
{
    // Contrato (interface) do repositório de usuários
    public interface IUsuarioRepositorio
    {
        Task<bool> Cadastrar(UsuarioModel usuario, string senhaPura);
        Task<UsuarioModel?> BuscarEmail(string email);
    }
}