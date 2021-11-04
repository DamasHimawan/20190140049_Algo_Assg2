using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class method1
    {
        int[] Damas = new int[69];

        int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Enter the number the elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 69)
                    break;
                else
                    Console.WriteLine("maximum 69 elements.");
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("--------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                Damas[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("--------------------");

            for (int dh = 0; dh < n; dh++)
            {
                Console.WriteLine(Damas[dh]);
            }
        }

        public void sort()
        {
            for (int i = 1; i < n - 1; i++)
            {
                int Temp = Damas[i];
                int dh = i - 1;

                while (dh < 0 && Damas[dh] < Temp)
                {
                    Damas[dh + 1] = Damas[dh];
                    dh++;
                }
                Damas[dh + 1] = Temp;
            }
            return;

        }

    }
}