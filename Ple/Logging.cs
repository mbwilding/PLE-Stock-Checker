using Serilog;

namespace Ple;

public static class Logging
{
    public static void Init(string query)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Async(x => x.Console())
            .WriteTo.Async(x => x.File(@$"Logs\{query}_{DateTime.Now:yyyy-MM-dd_hh-mm-ss}.log"))
            .CreateLogger();
        
        Log.Information("Searching for: {Query}", query);
    }
}