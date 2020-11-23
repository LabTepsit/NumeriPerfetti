using System;

namespace NumeriPerfetti
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i = 1;
            int somma = 0;

            Console.WriteLine("Inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            while (i < numero)
            {
                if(numero%i == 0)
                {
                    somma = somma + i;
                }
                i++;
            }

            if(numero == somma)
            {
                Console.WriteLine("è perfetto");
            }
            else
            {
                Console.WriteLine("non è perfetto");
            }
            Console.ReadLine();

        }
    }
}
