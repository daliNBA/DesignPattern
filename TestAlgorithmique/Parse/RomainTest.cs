using System;

namespace TestAlgorithmique.Parse
{
    public class RomainTest : IParse
    {
        private readonly int _number;

        public RomainTest(int number)
        {
            _number = number;
        }

        //Mon test
        public void ParseToRomain()
        {
            int k;
            if (_number >= 50)
            {
                k = _number % 50;
                Console.WriteLine("L");
            }
            else
                k = _number;
            if (k >= 10)
            {
                int X = k / 10;
                k %= 10;
                for (int i = 0; i < X; i++)
                {
                    Console.WriteLine("X");
                }
            }

            if (k >= 5)
            {
                int V = k / 5;
                k %= 5;
                for (int i = 0; i < V; i++)
                {
                    Console.WriteLine("V");
                }
            }
            if (k > 0)
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("I");
                }
        }

        //Seconde solution
        public void ParseToRomainTwo()
        {
            int k;
            int[] romain = { 10, 5 };
            string[] nombre = { "X", "V" };

            if (_number >= 50)
            {
                k = _number % 50;
                Console.WriteLine("L");
            }
            else
                k = _number;

            for (int i = 0; i < nombre.Length; i++)
            {
                if (k >= romain[i])
                {
                    int X = k / romain[i] > 0 ? k / romain[i] : 0;
                    k %= romain[i];
                    for (int j = 0; j < X; j++)
                    {
                        Console.WriteLine(nombre[i]);
                    }
                }

            }
            if (k > 0)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine("I");
                }

            }
        }
    }
}
