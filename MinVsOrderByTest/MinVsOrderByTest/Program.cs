using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MinVsOrderByTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CollectionCount = 1000000;
            const int MinLength = 5;
            const int MaxLength = 30;

            Stopwatch stopWatch = new Stopwatch();
            IList<string> TestList = new List<string>();
            IEnumerable<string> TestEnum = new List<string>();

            Console.WriteLine("Test collection init");

            for (var i = 0; i< CollectionCount; i++)
            {
                TestList.Add(RandGenerator.RandomStringInRange(MinLength, MaxLength));
            }
            TestEnum = TestList;

            Console.WriteLine("Init done!");

            Console.WriteLine($"ListCollection test:");

            stopWatch.Start();
            var orderByRes = TestList.OrderBy(a => a).First();
            stopWatch.Stop();
            Console.WriteLine($"Order().First() Result: {orderByRes} Time: {stopWatch.ElapsedMilliseconds}ms");

            stopWatch.Reset();

            stopWatch.Start();
            var minRes = TestList.Min();
            stopWatch.Stop();
            Console.WriteLine($"Min() Result: {minRes} Time: {stopWatch.ElapsedMilliseconds}ms");

            stopWatch.Reset();

            Console.WriteLine($"EnumCollection test:");

            stopWatch.Start();
            orderByRes = TestEnum.OrderBy(a => a).First();
            stopWatch.Stop();
            Console.WriteLine($"Order().First() Result: {orderByRes} Time: {stopWatch.ElapsedMilliseconds}ms");

            stopWatch.Reset();

            stopWatch.Start();
            minRes = TestEnum.Min();
            stopWatch.Stop();
            Console.WriteLine($"Min() Result: {minRes} Time: {stopWatch.ElapsedMilliseconds}ms");

            Console.WriteLine("Press any key to finish ;)");
            Console.ReadLine();
        }
    }
}
