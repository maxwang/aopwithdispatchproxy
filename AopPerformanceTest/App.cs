using RealProxyPerformanceTest.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RealProxyPerformanceTest
{
    public class App
    {
        private readonly ITaxCalculator _taxCalculator;
        public App(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator ?? throw new ArgumentNullException(nameof(taxCalculator));
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            _taxCalculator.CalculateTax("test1");
            stopwatch.Stop();
            Console.WriteLine($"Calculation wihtou realproxy is: {stopwatch.ElapsedMilliseconds} ms");


        }

    }
}
