
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenI
{

    class ClsLibro
    {

        private static int opcion = 0;
        public ArrayList titulo = new ArrayList();
        public ArrayList autor = new ArrayList();
        public ArrayList año = new ArrayList();
        public ArrayList precio = new ArrayList();
        public ArrayList disponible = new ArrayList();
        

        public ClsLibro() { }

        public ClsLibro(string titulo, string autor, int año, int precio)
        {
            this.titulo.Add(titulo);
            this.autor.Add(autor);
            this.año.Add(año);
            this.precio.Add(precio);
        }
        interface ILibro
        {
            void Devolver();
            void Prestar();
            void MostrarInformacion();
        }

        public void Devolver()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el titulo:");
            titulo.Add(Console.ReadLine());
            Console.WriteLine("Ingrese el autor:");
            autor.Add(Console.ReadLine());
            Console.WriteLine("Ingrese el año");
            año.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el precio");
            precio.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("El libro se encuentra disponible");
            Console.WriteLine("Presione cualquier tecla para continuar :)");
        }
        public void Prestar()
        {
            Console.Clear();
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"Titulo:     {titulo[i]}||Autor:      {autor[i]} ||Año de Publicación:      {año[i]} ||Precio:      {precio[i]} ||Disponible:    El libro se encuentra disponible");
            }
            Console.WriteLine("Ingrese el titulo del libro a prestar");
            string Consultatitulo = Console.ReadLine();
            Boolean disponible = false;
            for (int i = 0; i < titulo.Count; i++)
            {
                if (titulo[i].Equals(Consultatitulo))
                {
                    titulo.RemoveAt(i);
                    autor.RemoveAt(i);
                    año.RemoveAt(i);
                    precio.RemoveAt(i);
                    disponible = true;
                    Console.WriteLine("El libro se ha prestado");
                    continue;
                }
            }
            if (!disponible)
            {
                Console.WriteLine("El libro no se encuentra disponible");
            }
            Console.WriteLine("Presione cualquier tecla para continuar :)");
            Console.ReadLine();
        }

        public void MostrarInformacion()
        {
            Console.Clear();
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"Titulo:     {titulo[i]}||Autor:     {autor[i]}||Año de Publicación:     {año[i]}||Precio:     {precio[i]}||Disponible:    El libro se encuentra disponible");
            }
            Console.WriteLine("Presione cualquier tecla para continuar :)");
            Console.ReadLine();
        }
        public void BuscarLibros()
        {
            Console.Clear();
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"Titulo:     {titulo[i]}||Autor:      {autor[i]} ||Año de Publicación:      {año[i]} ||Precio:      {precio[i]} ||Disponible:    El libro se encuentra disponible");
            }
            Boolean disponible = false;
            Console.WriteLine("Ingrese el título del libro a buscar");
            string ConsultaL = Console.ReadLine();
            for (int i = 0; i < titulo.Count; i++)
            {
                if (titulo[i].Equals(ConsultaL))
                {
                    Console.WriteLine("El libro consultado es el siguiente");
                    Console.WriteLine($"Titulo:     {titulo[i]}||Autor:     {autor[i]}||Año de Publicación:     {año[i]}||Precio:     {precio[i]}||Disponible:    El libro se encuentra disponible");
                    disponible = true;
                    Console.ReadLine();
                }
                if (!disponible)
                {
                    Console.WriteLine("El libro no se encuentra disponible");
                }
                Console.WriteLine("Presione cualquier tecla para continuar :)");
                Console.ReadLine();
            }
        }
        public void LibroMC()
        {
            int maximo = int.MinValue;
            foreach (int numero in precio)
            {
                if (numero > maximo)
                {
                    maximo = numero;

                }


            }
            Boolean disponible = false;
            for (int i = 0; i < precio.Count; i++)
            {
                if (precio[i].Equals(maximo))
                {
                    Console.WriteLine("El libro con el mayor precio es:");
                    Console.WriteLine($"Titulo:     {titulo[i]}||Autor:     {autor[i]}||Año de Publicación:     {año[i]}||Precio:     {precio[i]}||Disponible:    El libro se encuentra disponible");
                    disponible = true;
                    Console.ReadLine();
                }
                if (!disponible)
                {
                    Console.WriteLine("El libro no se encuentra disponible");
                }
                Console.WriteLine("Presione cualquier tecla para continuar :)");
                Console.ReadLine();
            }

        }
        public void LibrosMC()
        {
            ArrayList Minimos = EncontrarMinimos(precio, 3);
            ArrayList EncontrarMinimos(ArrayList precio, int cantidad)
            {
                ArrayList minimos = new ArrayList();

                for (int i = 0;i < cantidad; i++)
                {
                    int minimo = int.MaxValue;

                    foreach (int numero in precio)
                    {
                        if (numero < minimo && !minimos.Contains(numero))
                        {
                            minimo = numero;
                        }
                    }
                    if (minimo != int.MaxValue)
                    {
                        minimos.Add(minimo);
                    }

                }
                return minimos;
            }
            Boolean disponible = false;
            for (int i = 0; i < precio.Count; i++)
            {
                if (precio[i].Equals(Minimos))
                {
                    Console.WriteLine("El libro con el mayor precio es:");
                    Console.WriteLine($"Titulo:     {titulo[i]}||Autor:     {autor[i]}||Año de Publicación:     {año[i]}||Precio:     {precio[i]}||Disponible:    El libro se encuentra disponible");
                    disponible = true;
                    Console.ReadLine();
                }
                if (!disponible)
                {
                    Console.WriteLine("El libro no se encuentra disponible");
                }
                Console.WriteLine("Presione cualquier tecla para continuar :)");
                Console.ReadLine();
            }


        }
        public void BuscarLibrosA()
        {
            Console.Clear();
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"Titulo:     {titulo[i]}||Autor:      {autor[i]} ||Año de Publicación:      {año[i]} ||Precio:      {precio[i]} ||Disponible:    El libro se encuentra disponible");
            }
            Boolean disponible = false;
            Console.WriteLine("Ingrese el autor del libro a buscar");
            string ConsultaL = Console.ReadLine();
            for (int i = 0; i < titulo.Count; i++)
            {
                if (autor[i].Equals(ConsultaL))
                {
                    Console.WriteLine("El libro consultado es el siguiente");
                    Console.WriteLine($"Titulo:     {titulo[i]}||Autor:      {autor[i]} ||Año de Publicación:      {año[i]} ||Precio:      {precio[i]} ||Disponible:    El libro se encuentra disponible");
                    disponible = true;
                    Console.ReadLine();
                }
                if (!disponible)
                {
                    Console.WriteLine("El libro no se encuentra disponible");
                }
                Console.WriteLine("Presione cualquier tecla para continuar :)");
                Console.ReadLine();
            }

        }

    }
}
