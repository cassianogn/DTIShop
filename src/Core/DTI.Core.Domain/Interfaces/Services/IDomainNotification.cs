using DTI.Core.Domain.Services.DomainNotifications;

namespace DTI.Core.Domain.Interfaces.Services
{
    public interface IDomainNotificationSerivce
    {
        IReadOnlyCollection<DomainNotification> GetNotifications();
        void AddNotification(DomainNotification notification);
    }
}
