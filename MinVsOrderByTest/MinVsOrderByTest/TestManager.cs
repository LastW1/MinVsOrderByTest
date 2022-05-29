using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MinVsOrderByTest
{
    public static class TestManager
    {
        public static double TestCaseRunner(TestCase testCase, int testLoops, int listItemsCount)
        {
            var stopWatch = new Stopwatch();
            long timerSum = 0;

            switch (testCase)
            {
                case TestCase.Min:
                    for (int i = 0; i < testLoops; i++)
                    {
                        timerSum += MinStopWatchRun(stopWatch, RandGenerator.GenerateRandomStringList(listItemsCount));
                    }
                    break;
                case TestCase.OrderBy:
                    for (int i = 0; i < testLoops; i++)
                    {
                        timerSum += OrderByStopWatchRun(stopWatch, RandGenerator.GenerateRandomStringList(listItemsCount));
                    }
                    break;
            }

            return (double)timerSum / testLoops;
        }

        private static long OrderByStopWatchRun(Stopwatch stopWatch, List<string> testCollection)
        {
            stopWatch.Reset();
            stopWatch.Start();
            var orderByRes = testCollection.OrderBy(a => a).First();
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        private static long MinStopWatchRun(Stopwatch stopWatch, List<string> testCollection)
        {
            stopWatch.Reset();
            stopWatch.Start();
            var orderByRes = testCollection.Min();
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
    }
}
