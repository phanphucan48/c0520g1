using System;

namespace BT_so_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;

            do
            {
                Console.WriteLine("nhap so");
                so = int.Parse(Console.ReadLine());
            } while (so < 2);

            int i;

            for (i = 2; i < so; i++)
            {

                bool check = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }

                }
                if (check)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}












