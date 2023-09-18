namespace OrderProcessor;

public class AnotherWorker : BackgroundService
{
    private readonly ILogger<AnotherWorker> _logger;

    public AnotherWorker(ILogger<AnotherWorker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("AnotherWorker running at: {time}", DateTimeOffset.Now);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }

}