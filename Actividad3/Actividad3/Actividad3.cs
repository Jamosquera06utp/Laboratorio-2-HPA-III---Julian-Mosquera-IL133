using System;

namespace LibroCalificacionesModificadores
{
    public class LibroCalificaciones
    {
        private string nombreCurso;

        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre;
        }

        public string NombreCurso 
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }

        public void MostrarMensaje()
        {

            Console.WriteLine("Bienvenido al libro de calificaiones para: \n{0}!", NombreCurso);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programacion en C#");
            LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructuras de Datos");
            
            Console.WriteLine("EL nombre del curso es: {0}", myLibro.NombreCurso);
            Console.WriteLine("El nombre del curso es: {0}", myLibro2.NombreCurso);
            
            Console.WriteLine("\nEscriba el nombre del curso:");
            string elNombreCurso = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(elNombreCurso))
            {
                Console.WriteLine("no se aceptan vacios, Escriba el nombre del curso:");
                elNombreCurso = Console.ReadLine();
            }
            
            myLibro.NombreCurso = elNombreCurso; 
            
            Console.WriteLine("ingrese cuantos estudiantes hay:");
            string numEst = Console.ReadLine();
            int estudiantes;

            while (!int.TryParse(numEst, out estudiantes))
            {
                Console.WriteLine("Error eso no es numero. ingrese los estudiantes:");
                numEst = Console.ReadLine();
            }


            Console.WriteLine("el nombre del curso es: {0} y tiene {1} estudiantes", myLibro.NombreCurso, estudiantes);

        }
    }
}
