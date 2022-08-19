using System;
using System.Diagnostics;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var watch = Stopwatch.StartNew();
                for (int k = 0; k < 5000; k++)
                {
                    try
                    {
                        var num = int.Parse("xxx");
                    }
                    catch (Exception ex) { 
                        Console.WriteLine(ex.Message);
                    }
                }
                watch.Stop();

                Console.WriteLine($"i={i + 1},耗费：{watch.ElapsedMilliseconds}");
            }
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                var watch = Stopwatch.StartNew();

                for (int k = 0; k < 5000; k++)
                {
                    var num = int.TryParse("xxx", out int reuslt);
                }

                watch.Stop();

                Console.WriteLine($"i={i + 1},耗费：{watch.ElapsedMilliseconds}");
            }
            Console.ReadLine();
        }
    }
}