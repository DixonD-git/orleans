using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SiloHost1
{
    public class TestStartup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var t = typeof(CSharpScript);

            return services.BuildServiceProvider();
        }
    }
}