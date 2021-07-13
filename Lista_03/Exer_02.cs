using System;

namespace Exer_02
{
    class Exer_02
    {
        static void Main(string[] args)
        {
            int w = 1, dw=1;
            for (int f = 1; f <= 100; f++)
            {
                Console.Write(f+", ");
            }

            Console.WriteLine();
            while (w <= 100)
            {
                Console.Write(w+", ");
                w++;
            }

            Console.WriteLine();
            do
            {
                Console.Write(dw + ", ");
                dw++;
            } while (dw <= 100);
        }
    }
}
