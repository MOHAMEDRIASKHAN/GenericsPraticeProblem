using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericDemo
{
    class program
    {
        //public static void toprint<T>(T[] inputArray)
        //{
        //    foreach (var element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("------------");
        //}

        //public static void toprint(double[] inputArray)
        //{
        //    foreach (double element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("------------");
        //}

        //public static void toprint(char[] inputArray)
        //{
        //    foreach (char element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("------------");
        //}

        public static void Main(string[] args)
        {
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //char[] charArray = { 'R', 'I', 'Y', 'A', 's' };

            //program.toprint<int>(intArray);
            //program.toprint<double>(doubleArray);
            //program.toprint<char>(charArray);

            //print<int> obj1 = new print<int>(intArray);
            //obj1.toprint();
            //print<double> obj2 = new print<double>(doubleArray);
            //obj2.toprint();
            //print<char> obj3 = new print<char>(charArray);
            //obj3.toprint();

            //int a = 20, b = 30, c =80;

            //print<int> obj1 = new print<int>();
            //int val = obj1.PrintMaximum(a, b, c);

            //Console.WriteLine(val);

            int[] arr = { 112, 334, 456, 598, 623 };
            ExtendTheMax<int> generic = new ExtendTheMax<int>(arr);
            generic.PrintMaxValue();
        }
    }
}