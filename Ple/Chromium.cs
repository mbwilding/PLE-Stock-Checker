using PuppeteerSharp;

namespace Ple;

public class Chromium : IDisposable
{
    private readonly BrowserFetcher _browserFetcher;
    private IBrowser _browser;

    public IPage Page;
    
    public Chromium()
    {
        _browserFetcher = new BrowserFetcher();
    }

    public async Task Init()
    {
        await _browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
        _browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
        Page = await _browser.NewPageAsync();
    }

    public void Dispose()
    {
        _browserFetcher.Dispose();
        _browser.Dispose();
        Page.Dispose();
    }
}