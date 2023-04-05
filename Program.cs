using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01._04._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray arr= new MyArray();
            arr.ShowArr();
            //float maxel = arr.MaxEl();
            //Console.WriteLine("\n\tМаксимальное общее значение: " + maxel);
            //float minel = arr.MinEl();
            //Console.WriteLine("\n\tМинимальное общее значение: " + minel);
            //Console.WriteLine("\n\tСумма всех элементов: " + arr.SumTotal());
            //Console.WriteLine("\n\tРезультат умножения всех элементов: " + arr.Multip());
            //Console.WriteLine("\n\tРезультат cложения парных элементов массива А: " + arr.SumPairA());
            //Console.WriteLine("\n\tРезультат cложения непарных столбцов массива В: " + arr.SumnPairColsB());
            Console.Write("\n\tВведите число для сравнения с элементами массивов: ");
            int compare=Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n\tКоличество элементов, меньших, чем заданное число: " + arr.Less(compare));
            Console.WriteLine("\n\tКоличество элементов, больших, чем заданное число: " + arr.Greater(compare));
            arr.ShowEven();
            arr.ShowOdd();

            Console.WriteLine("\n\tКоличество уникальных элементов: " + arr.CountDistinct());
            Console.WriteLine("\n\tКоличество значений, равных заданнному числу: " + arr.EqualToValue(compare));
            Console.ReadLine();
        }
    }
}
