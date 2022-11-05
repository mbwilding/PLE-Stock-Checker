using System.Text;
using System.Text.Json;
using ComposableAsync;
using Serilog;

namespace Ple;

public class Process
{
    private readonly Chromium _chromium;
    private readonly Rate _rate;
    private readonly string _query;
    
    public Process(Chromium chromium, int rate, string query)
    {
        _rate = new Rate(rate);
        _chromium = chromium;
        _query = $"https://www.ple.com.au/Search/{query}";
    }
    
    public async Task Init()
    {
        while (true)
        {
            await _rate.Limit;
    
            await _chromium.Page.GoToAsync(_query);
            var content = await _chromium.Page.GetContentAsync();

            WebInfo? ple;
            try
            {
                var json = Filter.ContentToJson(content);
                ple = JsonSerializer.Deserialize<WebInfo>(json);
            }
            catch
            {
                Log.Information("No stock found");
                continue;
            }

            List<ItemDatumClass> items = Filter.Flatten(ple);

            if (items.Any(x => x.Availabilities.Any(y => y.InStock)))
            {
                // Audible alert (Should be cross-platform unlike Console.Beep)
                Console.Write('\a');

                StringBuilder sb = new StringBuilder("STOCK\n");

                // List out items and availability
                foreach (var item in items.Where(item => item.Availabilities.Any(x => x.InStock)))
                {
                    sb.Append($"\n---------ITEM---------\n{item.ItemDescription}\n-------LOCATION-------\n");
                    foreach (var store in item.Availabilities.Where(store => store.InStock))
                        sb.Append($"{store.Location}\n");
                }
        
                Log.Information("{Location}", sb.ToString());
            }
            else
            {
                Log.Information("No stock found");
            }
        }
    }
}