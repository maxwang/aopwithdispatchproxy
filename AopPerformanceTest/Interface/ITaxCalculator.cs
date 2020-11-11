using System;
using System.Collections.Generic;
using System.Text;

namespace RealProxyPerformanceTest.Interface
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(string productId);
    }
}
