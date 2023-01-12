using DTI.Core.Domain;
using DTI.Core.Domain.Events.DomainNotifications;
using DTI.Core.Domain.Interfaces.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DTI.Core.Tests.Integration.DomainNotification
{
    public class DomainNotificationTests
    {
        
        [Fact(DisplayName ="Integracao.DomainNotification.AddEvento")]
        public async Task DomainNotification_AddEvento_DeveAdicionarNasNotificacoesAsync()
        {
            // ARRANGE
            var providers = GetScopProviders();
            var bus = providers.GetService<IMediator>()!;
            var @event = new DomainNotificationEvent("teste", "teste");
            var domainNotificationService = providers.GetRequiredService<IDomainNotificationSerivce>();

            // ACATION
            await bus.Publish(@event);

            //ASSERT
            var assertNotifications = domainNotificationService
                .GetNotifications()
                .Where(notification => notification.Code == @event.Code 
                                    && notification.Description == @event.Description);
            Assert.Single(assertNotifications);
        }

        private static ServiceProvider GetScopProviders()
        {
            var scope = new ServiceCollection();
            scope.AddDomainCoreModule();
            var providers = scope.BuildServiceProvider();
            return providers;
        }
    }
}
