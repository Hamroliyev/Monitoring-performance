using System;
using System.Diagnostics;
using static System.Diagnostics.Process;

namespace MonitoringLib
{
    public static class Recorder
    {
        static Stopwatch stopwatch = new Stopwatch();
        static long bytesPhysicalBefore = 0;
        static long bytesVirtualBefore = 0;
        public static void Start()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
            stopwatch.Restart();
        }

        public static void Stop()
        {
            stopwatch.Stop();
            long bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;

            Console.WriteLine("{0:N0} physical bytes used.",bytesPhysicalAfter - bytesPhysicalBefore);
            Console.WriteLine("{0:N0} virtual bytes used.",bytesVirtualAfter - bytesVirtualBefore);

            Console.WriteLine("{0} time span ellapsed.", stopwatch.Elapsed);
            Console.WriteLine("{0:N0} total milliseconds ellapsed.",stopwatch.ElapsedMilliseconds);
        }
    }
}
