using System.Text.RegularExpressions;

namespace Ple;

public static class Filter
{
    private static Regex _json = new(@"<script>window._INITIAL_DATA_=(?m).*<\/script>", RegexOptions.Multiline | RegexOptions.Compiled);

    public static string ContentToJson(string? content)
    {
        return _json.Matches(content!)
            .FirstOrDefault()?.Captures
            .FirstOrDefault()?
            .ToString()
            .Replace("<script>window._INITIAL_DATA_=", string.Empty)
            .Replace(@"</script>", string.Empty)
            .Replace("\":undefined", "\": \"\"")!;
    }

    public static List<ItemDatumClass> Flatten(WebInfo? ple)
    {
        return(
                from initialData in ple?.InitialData
                where initialData is not null
                where initialData.SearchGridData is not null
                from itemData in initialData.SearchGridData.ItemData
                select itemData)
            .ToList();
    }
}