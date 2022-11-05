using RateLimiter;

namespace Ple;

public class Rate
{
    public TimeLimiter Limit;
    
    public Rate(int pollSeconds)
    {
        Limit = TimeLimiter.GetFromMaxCountByInterval(1, TimeSpan.FromSeconds(pollSeconds));
    }
}