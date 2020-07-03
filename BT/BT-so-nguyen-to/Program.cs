using System;

namespace BT_so_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 100; i++)
            {
                if (kiemtrasnt(i))
                {
                    Console.Write(i + ";");
                }

            }

        }
        public static bool kiemtrasnt(int number)
        {
            bool check = true;
            if (number < 2)
            {
                check = false;
            }

            else
            {
                int i = 2;

                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }

            }
            return check;
        }
    }
}
