using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01._04._23
{
    internal class MyArray:ICalc, IOutput2, ICalc2
    {
        private float[] A = new float[5];
        private float[,] B = new float[3, 4];
        private Random r = new Random();
        //public int a { get; set; }
        public MyArray()
        {
            Console.WriteLine("\n\tВведите значение элемента одномерного массива:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" ");
                A[i] = float.Parse(Console.ReadLine()); ;
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = (float)r.NextDouble() * 10;
                }
            }
        }

        public void ShowArr()
        {
            Console.Write("\n\tОдномерный массив: \n\t");
            foreach (var k in A)
            {
                Console.Write(k + "  ");
            }
            Console.WriteLine();
            Console.Write("\n\tДвумерный массив: \n\t");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public float MaxEl()
        {
            float max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            float maxB = B[0, 0];
            int maxARound = (int)max;
            float tmp = B[0, 0];
            for (int j = 0; j < B.GetLength(0); j++)
            {
                for (int i = 0; i < B.GetLength(1); i++)
                {
                    if (B[j, i] == max)
                    {
                        return max;
                    }
                    //Если абсолютно одинаковых значений нет, приводим к int и определяем максимально общее значение второго массива
                    else if ((int)(B[j, i]) == maxARound)
                    {
                        tmp = B[j, i];
                        if (tmp > B[j, i])
                        { maxB = B[j, i]; }
                        else
                            maxB = tmp;
                    }
                }
            }
            Console.WriteLine($"\n\tОбщих идентичных максимальных значений не найдено, " +
                            "\n\tно если округлить числа,максимально общими будут: " +
                            "\n\tдля массива А: {0}, для массива B: {1}, результат операции - большее значений из них.", max, maxB);
            if (max > maxB)
                return max;
            else
                return maxB;
        }

        public float MinEl()
        {
            float min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            float minB = B[0, 0];
            int minARound = (int)min;
            float tmp = B[0, 0];
            for (int j = 0; j < B.GetLength(0); j++)
            {
                for (int i = 0; i < B.GetLength(1); i++)
                {
                    if (B[j, i] == min)
                    {
                        return min;
                    }
                    //Если абсолютно одинаковых значений нет, приводим к int и определяем минимальное общее значение второго массива
                    else if ((int)(B[j, i]) == minARound)
                    {
                        tmp = B[j, i];
                        if (tmp < B[j, i])
                        { minB = B[j, i]; }
                        else
                            minB = tmp;
                    }
                }
            }
            Console.WriteLine($"\n\tОбщих идентичных минимальных значений не найдено, " +
                            "\n\tно если округлить числа, общими будут: " +
                            "\n\tдля массива А: {0}, для массива B: {1}, результат операции - наименьшее из них.", min, minB);
            if (min < minB)
                return min;
            else
                return minB;
        }

        public float SumTotal()
        {
            float sum = 0;
            foreach (var el in A)
            {
                sum += el;
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                }
            }
            return sum;
        }

        public float Multip()
        {
            float mul = 1;
            foreach (var el in A)
            {
                mul *= el;
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    mul *= B[i, j];
                }
            }
            return mul;
        }

        public float SumPairA()
        {
            float sum = 0;
            foreach (var el in A)
            {
                if (el % 2 == 0)
                {
                    sum += el;
                }
            }

            return sum;
        }

        public float SumnPairColsB()
        {
            float sum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j % 2 != 0)
                    {
                        sum += B[i, j];
                    }
                }
            }
            return sum;
        }

        public int Less(int n) 
        {
            int count = 0;
            foreach (var el in A)
            {
                if ((int)el <n)
                {
                    count++; ;
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if ((int)B[i,j] < n)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int Greater(int n) 
        {
            int count = 0;
            foreach (var el in A)
            {
                if (el > n)
                {
                    count++; ;
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > n)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void ShowEven()
        {
            Console.Write("\n\tПарные значения одномерного массива: ");
            foreach (var el in A)
            {
                if (el % 2 == 0)
                {
                    Console.Write(el + "  "); ;
                }
            }
            Console.WriteLine();
            Console.Write("\n\tПарные значения двумерного массива: \n\t");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if ((int)B[i, j]%2==0)
                    Console.Write((int)B[i, j] + " ");
                }
                //Console.WriteLine();
            }
        }

        public void ShowOdd()
        {
            Console.Write("\n\tНепарные значения одномерного массива: ");
            foreach (var el in A)
            {
                if (el % 2 != 0)
                {
                    Console.Write(el + "  "); ;
                }
            }
            Console.WriteLine();
            Console.Write("\n\tНепарные значения двумерного массива: \n\t");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if ((int)B[i, j] % 2 != 0)
                        Console.Write((int)B[i, j] + " ");
                }
                //Console.WriteLine();
            }
        }

        public void SortArrB()
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        if (B[k, j] > B[k, j + 1])
                        {
                            float tmp = B[k, j];
                            B[k, j] = B[k, j + 1];
                            B[k, j + 1] = tmp;
                        }
                    }

                }
            }
        }
        public int CountDistinct()
        {
            int count = 0;
            Array.Sort(A);
            for(int i=0; i<A.GetLength(0)-1; i++) 
            {
                if (A[i] != A[i + 1])
                    count++;
            }
            
            SortArrB();
            for (int i=0; i<B.GetLength(0) - 1; i++)
            {
                for (int j=0; j<B.GetLength(1)-1; j++)
                {
                    if (B[i, j] != B[i + 1, j + 1])
                        count++;
                }
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i] == valueToCompare)
                    count++;
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] == valueToCompare)
                        count++;
                }
            }
            return count;
        }
    }
}
