using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace RealProxyPerformanceTest.Aop
{
    public class DynamicProxy<T> : DispatchProxy
    {
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            if(targetMethod == null)
            {
                throw new ArgumentException(nameof(targetMethod));
            }

            throw new NotImplementedException();
        }
    }
}
