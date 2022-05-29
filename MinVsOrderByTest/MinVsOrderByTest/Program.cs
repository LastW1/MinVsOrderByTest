using System;

namespace MinVsOrderByTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLinqTest(100000, 100);
            RunLinqTest(10000, 1000);

            Console.WriteLine("Press any key to finish ;)");
            Console.ReadLine();
        }

        private static void RunLinqTest(int items, int loops)
        {
            Console.WriteLine($"Linq {items} items, {loops} loops test start");
            var orderByRes = TestManager.TestCaseRunner(TestCase.OrderBy, loops, items);
            Console.WriteLine("OrderBy Ended");
            var minRes = TestManager.TestCaseRunner(TestCase.Min, loops, items);
            Console.WriteLine("Min Ended");
            Console.WriteLine($"Results: \nOrderBy avarage: {orderByRes}\nMinAvarage: {minRes}");
            if (orderByRes > minRes)
            {
                Console.WriteLine($"Min is {minRes / orderByRes * 100}% faster");
            }
            else
            {
                Console.WriteLine($"OrderBy is {orderByRes / minRes * 100}% faster");
            }
        }
    }
}
