using System;

namespace LibroCalificaciones_1
{
    public class LibroCalificacion
    {
        public void MostrarMensaje()
        {

            Console.WriteLine("Bienvenido al libro de calificaciones");
        }
    }

    class PruebaLibroCalificaciones_1
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Ingrese la cantidad de materias que da:");
            string cantStr = Console.ReadLine();
            int cant;
            while(!int.TryParse(cantStr, out cant)){
                Console.WriteLine("error esto no es numero, ingrese de nuevo:");
                cantStr = Console.ReadLine();
            }

            LibroCalificacion MyLibro = new LibroCalificacion();
            MyLibro.MostrarMensaje();
            
        }
    }
}
