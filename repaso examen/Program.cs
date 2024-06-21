using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace repaso_examen
{
    internal class Program

        
    {
       static string nombre = "";
        static string categoria = "";
        static int precio = 0;
        static int cantidad = 0;
        static bool disponibilidad = false;
        static int opcion = 0;
        static int contador = 0;

        static void Main(string[] args)
        {

           

            void IngresoDatos()
            {
                Console.WriteLine(" bienvenido, ingrese el nombre del producto");
                nombre = Console.ReadLine();
                Console.Write(" ingrese la categoria: ");
                categoria = Console.ReadLine();
                Console.Write(" ingrese el precio: ");
                precio= int.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese la cantidad total en stock");
                cantidad = int.Parse(Console.ReadLine());

                disponibilidad = true;

            }

            void Informacion () 
            {
                if (disponibilidad == true)
                {
                    Console.WriteLine(" nombre del producto: " + nombre);
                    Console.WriteLine(" categoria: " + categoria);
                    Console.WriteLine(" precio: " + precio);
                    Console.WriteLine(" cantidad: " + cantidad);
                }
                else { Console.WriteLine(" el producto no fue ingresado"); }
            }

            void ValorTotal() 
            {
             Console.WriteLine(" el valor total es " + precio * cantidad);
            }

            void ContadorVocales() 
            {
               
            for ( int i = 0; i < nombre.Length; i++ ) 
                {
                    if (nombre[i] == 'a' || nombre[i] == 'e' || nombre[i] == 'i' || nombre[i] == 'o' || nombre[i] == 'u' ||
                        nombre[i] == 'A' || nombre[i] == 'E' || nombre[i] == 'I' || nombre[i] == 'O' || nombre[i] == 'U') 
                    {
                        contador++;
                    }
                }
            Console.WriteLine(" LA CANTIDAD DDE VOCALES SON: " +  contador);


            }

            void Menu()
            {
                    Console.WriteLine(" a partir del siguiente menu elija una opcion");
                    Console.WriteLine(" 1) añadir un producto");
                    Console.WriteLine(" 2) mostrar informacion del producto");
                    Console.WriteLine(" 3) calcular el valor del stock del producto");
                    Console.WriteLine(" 4) mostrar la cantidad de vocales que tiene el producto");
                    Console.WriteLine(" 5) salir del programa");
               
            }
                   

            


            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: IngresoDatos(); break;
                    case 2: Informacion(); break;
                    case 3: ValorTotal(); break;
                    case 4: ContadorVocales(); break;
                    case 5: Console.WriteLine(" saliste del programa"); break;

                }

            } while (opcion != 5);


        }
    }
}
