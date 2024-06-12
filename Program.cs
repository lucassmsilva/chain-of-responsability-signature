using System;
using ChainOfResponsability.Domain;

namespace ChainOfResponsability
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var professor = new ProfessorAssinador();
            var coordenador = new CoordenadorAssinador();
            var secretaria = new SecretariaAssinador();
            
            professor.ProximoAssinador(coordenador);
            coordenador.ProximoAssinador(secretaria);
            
            professor.Assinar(new Documento(){Id = 1, Name = "Lista de Notas e faltas"});
            professor.Assinar(new Documento(){Id = 2, Name = "Registro de matéria"});
            professor.Assinar(new Documento(){Id = 3, Name = "Plano de Ensino"});

            Console.ReadKey();
        }
    }
}