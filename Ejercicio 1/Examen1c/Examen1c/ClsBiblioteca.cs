using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    class ClsBiblioteca : ClsLibro
    {
        public static ClsLibro libros = new ClsLibro();
        public static int opcion = 0;
        public static void MenuI()
        {
            var anInstanceofMyClass = new ClsBiblioteca();
            anInstanceofMyClass.Menu();

        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("|||||||||||||||SISTEMA BIBLIOTECA|||||||||||||||");
                Console.WriteLine("1. Agregar un libro a la biblioteca");
                Console.WriteLine("2. Eliminar un libro de la biblioteca");
                Console.WriteLine("3. Mostrar todos los libros de la biblioteca");
                Console.WriteLine("4. Buscar libros");
                Console.WriteLine("5. Mostrar libro de mayor precio");
                Console.WriteLine("6. Mostrar los tres libros de menor precio");
                Console.WriteLine("7. Buscar libros por inicio del nombre del autor");
                Console.WriteLine("8. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarLibro(); break;
                    case 2: EliminarLibro(); break;
                    case 3: MostrarLibros(); break;
                    case 4: BuscarLibrosF(); break;
                    case 5: LibroMCF(); break;
                    case 6: LibrosMC(); break;
                    case 7: BuscarLibrosAF(); break;
                    case 8: break;
                    default: Console.WriteLine("Digite una opción correcta"); break;
                }
            } while (opcion != 8);
        }
        public void AgregarLibro()
        {
            libros.Devolver();
        }
        public void EliminarLibro()
        {
            libros.Prestar();
        }
        public void MostrarLibros()
        {
            libros.MostrarInformacion();
        }
        public void BuscarLibrosF()
        {
            libros.BuscarLibros();
        }
        public void LibroMCF()
        {
            libros.LibroMC();
        }
        public void LibrosMCF()
        {
            libros.LibrosMC();
        }
        public void BuscarLibrosAF()
        {
            libros.BuscarLibros();
        }
    }
}
