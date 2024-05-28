using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace swmod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantal = 12000;
            int[] test = new int[aantal];
            for (int i = 0; i < aantal; i++)
            {
                test[i] = i;
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(LinearSumIterative(test, aantal));
            //Thread.Sleep(1200);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:000} microseconds", ts.TotalMilliseconds * 1000);
            Console.WriteLine("RunTime Iterative " + elapsedTime);
            stopWatch.Restart();
            Console.WriteLine(LinearSumRecursive(test, aantal));
            //Thread.Sleep(1400);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:000} microseconds", ts.TotalMilliseconds * 1000);
            Console.WriteLine("RunTime Recursive " + elapsedTime);
            Console.ReadKey();
        }
        static int LinearSumIterative(int[] testArray, int n)
        {
            //Console.WriteLine("call-iterative");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + testArray[i];
            }
            return sum;
        }
        static int LinearSumRecursive(int[] testArray, int n)
        {
            //Console.WriteLine("call-recursive");
            if (n == 1)
            {
                return testArray[0];
            }
            else
            {
                return LinearSumRecursive(testArray, n - 1) + testArray[n - 1];
            }
        }

    }
}

