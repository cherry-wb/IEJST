using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace IEJavascriptSpeedTester
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class Benchmark
    {
        Stopwatch bench;
        Stopwatch global;
        Action<string> ShowBench;
             
        public Benchmark(Action<string> showBench) {          
            ShowBench = showBench;
            global = new Stopwatch();
            global.Start();
        }

        public void startBench() {
            ShowBench(string.Format("Starting TEST at {0}\n", DateTime.Now));
            bench = Stopwatch.StartNew();
        }

        public string stopBench() {
            bench.Stop();
            ShowBench(string.Format("Stop the test at {0}: {1} ({2})\n",DateTime.Now,bench.Elapsed,bench.ElapsedMilliseconds));
            return bench.ElapsedMilliseconds.ToString();
        }

        public string preciseTime() {
            return global.Elapsed.TotalMilliseconds.ToString().Replace(',','.');
        }
        
    }

}
