using RealProxyPerformanceTest.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealProxyPerformanceTest.Services
{
    public class BasicTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(string productId)
        {
            Console.WriteLine($"ask tax for {productId}");
            return 10;
        }
    }
}
