using DTI.Core.Domain.Events.DomainNotifications;
using DTI.Core.Domain.Interfaces.Services;
using MediatR;

namespace DTI.Core.Domain.Services.DomainNotifications
{
    internal class DomainNotificationEventHandler : INotificationHandler<DomainNotificationEvent>
    {
        private readonly IDomainNotificationSerivce _domainNotificationSerivce;
        public DomainNotificationEventHandler(IDomainNotificationSerivce domainNotificationSerivce)
        {
            _domainNotificationSerivce = domainNotificationSerivce;
        }

        public Task Handle(DomainNotificationEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationSerivce.AddNotification(new DomainNotification(notification.Code, notification.Description));
            return Task.CompletedTask;
        }
    }
}
