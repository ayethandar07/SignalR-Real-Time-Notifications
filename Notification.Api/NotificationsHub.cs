using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Notification.Api;

[Authorize]
public class NotificationsHub : Hub<INotificationClient>
{
    public override async Task OnConnectedAsync()
    {
        await Clients.Client(Context.ConnectionId).ReceiveNotification(
            $"Thank you for connecting {Context.User?.Identity?.Name ?? "Guest"}");

        await base.OnConnectedAsync();
    }

}

public interface INotificationClient
{
    Task ReceiveNotification(string message);
}