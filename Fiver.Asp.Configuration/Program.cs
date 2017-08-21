using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Fiver.Asp.Configuration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        //public static IWebHost BuildWebHost(string[] args)
        //{
        //    return WebHost.CreateDefaultBuilder(args)
        //                   .ConfigureAppConfiguration((context, builder) =>
        //                   {
        //                       var env = context.HostingEnvironment;

        //                       builder
        //                        .AddJsonFile("appsettings.json", 
        //                            optional: false, reloadOnChange: true)
        //                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", 
        //                            optional: true, reloadOnChange: true)
        //                        .AddEnvironmentVariables();

        //                   })
        //                   .UseStartup<Startup>()
        //                   .Build();
        //}
    }
}
