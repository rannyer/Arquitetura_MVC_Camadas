using ArquiteturasMVC_Camadas.controllers;
using ArquiteturasMVC_Camadas.views;

namespace ArquiteturasMVC_Camadas;

class Program
{
    static void Main(string[] args)
    {
       AlunoController controller = new AlunoController(new AlunoView());
       ProfessorController prof_controller = new ProfessorController();
       string menu = "1";

       if (menu == "1")
       {
           controller.Executar();
       }else if (menu == "2")
       {
           prof_controller.Executar();  
       }
    }
}