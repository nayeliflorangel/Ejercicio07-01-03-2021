using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Escriba su nombre: ");
            name = Console.ReadLine().ToUpper();
            Console.Write("Letras: ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }
        }
    }
}
