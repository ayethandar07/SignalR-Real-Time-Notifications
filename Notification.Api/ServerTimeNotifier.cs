
using Microsoft.AspNetCore.SignalR;

namespace Notification.Api;

public class ServerTimeNotifier : BackgroundService
{
    private readonly TimeSpan _period;
    private readonly ILogger<ServerTimeNotifier> _logger;
    private readonly IHubContext<NotificationsHub, INotificationClient> _context;

    public ServerTimeNotifier(ILogger<ServerTimeNotifier> logger, IHubContext<NotificationsHub, INotificationClient> context, TimeSpan period)
    {
        _logger = logger;
        _context = context;
        _period = period;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var timer = new PeriodicTimer(_period);

        try
        {
            while (!stoppingToken.IsCancellationRequested
                && await timer.WaitForNextTickAsync(stoppingToken))
            {
                var dateTime = DateTime.Now;

                _logger.LogInformation("Executing {Service} at {Time}", nameof(ServerTimeNotifier), dateTime);

                await _context.Clients.All.ReceiveNotification($"Server time: {dateTime}");
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("{Service} was cancelled", nameof(ServerTimeNotifier));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred in {Service}", nameof(ServerTimeNotifier));
        }
        finally
        {
            _logger.LogInformation("{Service} is stopping", nameof(ServerTimeNotifier));
        }
    }
}

