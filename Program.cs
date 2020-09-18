using System;

namespace Validation_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad;
            int numero = 1;

            Console.WriteLine("Escribe un numero");

            Cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Cantidad; i++)
            {

                System.Console.Write(numero + ", ");

            }

            System.Console.Write(Cantidad);






        }
    }
}
