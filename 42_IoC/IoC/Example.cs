using IoC.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;
using IoC.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace IoC
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services=new ServiceCollection(); //built in IoC 

            services.Add(new ServiceDescriptor(typeof(ConsoleLog),new ConsoleLog()));
            services.Add(new ServiceDescriptor(typeof(TestLog), new TestLog()));

            ServiceProvider provider = services.BuildServiceProvider();//Somut container/provider/sağlayıcı, içinde yukarıdaki consoleLog ve TestLog var
            provider.GetService<ConsoleLog>();
            provider.GetService<TestLog>();
        }
       

    }
}
