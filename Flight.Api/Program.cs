using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Flight.Api;

/// <summary>
///     The program.
/// </summary>
public class Program
{
    /// <summary>
    ///     Mains the.
    /// </summary>
    /// <param name="args">The args.</param>
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    /// <summary>
    ///     Creates the host builder.
    /// </summary>
    /// <param name="args">The args.</param>
    /// <returns>An IHostBuilder.</returns>
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}