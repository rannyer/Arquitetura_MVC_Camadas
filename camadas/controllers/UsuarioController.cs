using camadas.models;
using camadas.services;
using camadas.views;

namespace camadas.controllers;

public class UsuarioController
{
    private readonly UsuarioService _service;
    private readonly UsuarioView _view;
    
    public UsuarioController(UsuarioService service, UsuarioView view)
    {
        _service = service;
        _view = view;
    }

    public void ProcessarDados()
    {
        var (nome, email, senha, idade) = _view.ColetarDados();
        var resultado = _service.CadastrarUsuario(new Usuario(0, nome, email, senha, idade));
        Console.WriteLine(nome);
    }
}