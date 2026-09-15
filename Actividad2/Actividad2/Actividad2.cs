using System;

namespace LibroCalificaciones_2
{
    public class MilibroCalificaciones
    {
        public void MostrarMensaje(string nombreCurso)
        {

            Console.WriteLine("¡Bienvenido al libro de calificaciones para: \n{0} !", nombreCurso);
        }
    }

    public class LibroPuebaCalificaciones
    {
        static void Main(string[] args)
        {            
            MilibroCalificaciones MyLibro = new MilibroCalificaciones();
            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            
            string nombreDelCurso = Console.ReadLine();

            while (string.IsNullOrEmpty(nombreDelCurso))
            {
                Console.WriteLine("el nombre no puede quedar vacio. Por favor ingrese de nuevo:");
                nombreDelCurso = Console.ReadLine();
            }

            Console.WriteLine();
            
            MyLibro.MostrarMensaje(nombreDelCurso);
            
        }
    }
}
