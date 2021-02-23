using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json",
                    optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var ts = new TraceSwitch(
                displayName: "MySwitch",
                description: "This switch is set via a Json file");
            configuration.GetSection("MySwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}

