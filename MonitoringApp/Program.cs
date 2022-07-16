using MonitoringLib;
using System;
using System.Linq;
using System.Threading;

namespace MonitoringApp
{
    class Program
    {
        /// <summary>
        ///     Monitoring performance and memory use
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            /*Console.WriteLine("Processing. Please wait...");
            Recorder.Start();
            // simulate a process that requires some memory resour
            int[] largeArrayOfInts =
            Enumerable.Range(1, 10_000).ToArray();
            // ...and takes some time to complete
            Thread.Sleep(new Random().Next(5, 10) * 1000);
            Recorder.Stop();
            Console.ReadKey();*/

            /*Measuring the efficiency of processing strings*/

            int[] numbers = Enumerable.Range(1, 50_000).ToArray();
            Console.WriteLine("Using string with +");
            Recorder.Start();
            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ", ";
            }
            Recorder.Stop();
            Console.WriteLine("Using StringBuilder");
            Recorder.Start();
            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                builder.Append(numbers[i]); builder.Append(", ");
            }
            Recorder.Stop();
            Console.ReadKey();
        }
    }
}
