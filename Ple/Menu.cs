using Serilog;

namespace Ple;

public static class Menu
{
    public static string Init(string[] args)
    {
        string? query = string.Empty;

        if (args.Any())
            query = string.Join(' ', args);

        while (string.IsNullOrWhiteSpace(query))
        {
            Console.Write("Search: ");
            query = Console.ReadLine();
            Console.Clear();
        }

        return query;
    }
}