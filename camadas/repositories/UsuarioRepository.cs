using camadas.models;

namespace camadas.repositories;

public class UsuarioRepository
{
    private readonly List<Usuario> _usuarios = new()
    {
        new Usuario(1,"Tim Maia", "timmaia@soquerdinheiro.com", "timtim123",28)
    };
    
    public void Salvar(Usuario usuario)
    {
        usuario.Id = _usuarios.Count+1;
        _usuarios.Add(usuario);
    }

    public Usuario? BuscarPorEmail(string email)
    {
        return _usuarios.FirstOrDefault(u => u.Email == email);
    }
    public List<Usuario> BuscarTodos() => _usuarios.ToList();

}