using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;
            Queue <string> cola = new Queue<string>();

            Console.Write("Ingrese una cadena: ");
            palabras = Console.ReadLine();  


            while (palabras != string.Empty)
            {
                cola.Enqueue(palabras);
                Console.Write("Ingrese la proxima cadena: ");
                palabras = Console.ReadLine();
            }
            while (cola.Count >0)
            {
                Console.WriteLine((string) cola.Dequeue()); 
            }

            Console.ReadKey();
        }
    }
}
