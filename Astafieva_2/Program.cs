using System;

namespace Astafieva_2
{
    class Program
    {
        //TASK 1
        static double Avg(double n, double m)
        {
            return (n + m) / 2;
        }




        static int Even_Summ(int t)
        {
            int summ = 0;
            for (int i = 0; i <= t; i += 2)
            {
                summ += i;
            }
            return summ;
        }




        static int Even_Sum_Diap(int n1, int m1)
        {
            int summ = 0;
            if (n1 > m1)
            {
                Console.WriteLine("Wrong range, enter the first number less than the second!");
                return 0;
            }

            else
            {
                for (int i = n1; i <= m1; i++)
                {
                    if (i % 2 == 0)
                    {
                        summ += i;
                    }
                }
            }
            return summ;

        }



        //TASK 2
        static int[] Swap(int[] array1)
        {
            int length = array1.Length;
            for (int count = 0; count < (length) / 2; count++)
            {
                int a = array1[count];
                int b = array1[length - count - 1];
                array1[length - count - 1] = a;
                array1[count] = b;
            }
            return array1;
        }


        static int Distance(int[] array)
        {
            int max = array[0];
            int last = 0;

            int first = 0;
            int[] dop_array = new int[array.Length];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == max)
                {
                    last = i;
                    break;
                }
            }
            for (int j = 0; j <= array.Length - 1; j++)
            {
                if (array[j] == max)
                {
                    first = j;
                    break;
                }

            }
            int distance = last - first;
            return distance;
        }

        //TASK 3

        static int[,] Matrix(int[,] mass)
        {
            if (mass.Length != mass.GetLength(0) || mass.Length == 1 && mass.GetLength(0) == 1)
            {
                Console.WriteLine("You entered not a square matrix. Try again!");
                return null;
            }

            if (mass.Length == 0)
            {
                Console.WriteLine("You have not entered the matrix. Try again!");
                return null;
            }
            else
            {
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(0); j++)
                    {
                        if (i == j)
                            mass[i, j] = mass[i, j];
                        else if (i > j)
                            mass[i, j] = 0;
                        else
                            mass[i, j] = 1;

                    }
                }
            }
            return mass;
        }


        static void Main(string[] args)
        {

            double n = 3;
            double m = 4;
            int t = 0;
            int m1 = 3;
            int n1 = 3;
            //Program.Even_Summ(n1);
            //Program.Even_Sum_Diap(n1, m1);
            int[] array1 = { 1, 2, 3, 4, 5 };
            //Program.Swap(array1);
            int[,] mass = { { 1 } };
            //int[,] mass = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }};
            //Program.Matrix(mass);
            int[] array = { 7, 5, 7, 4, 5, 2, 7 };
            //Program.Distance(array);

        }
    }
}
