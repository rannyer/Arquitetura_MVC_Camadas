using ArquiteturasMVC_Camadas.controllers;
using ArquiteturasMVC_Camadas.views;

namespace ArquiteturasMVC_Camadas;

class Program
{
    static void Main(string[] args)
    {
       AlunoController controller = new AlunoController(new AlunoView());
       controller.Executar();
    }
}