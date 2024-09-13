using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập cạnh đáy lớn (a):");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nhập cạnh đáy nhỏ (b):");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nhập chiều cao (h):");
            double h = Convert.ToDouble(Console.ReadLine());

            double dientich = (a + b) * h / 2;

            Console.WriteLine($"diện tích hình thang là :{dientich}");
        }
    }
}
