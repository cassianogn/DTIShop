using DTI.Core.Domain.Events.DomainNotifications;
using DTI.Core.Domain.Interfaces.Services;
using DTI.Core.Domain.Services.DomainNotifications;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.Core.Domain
{
    public static class DomainCoreModule
    {
        public static IServiceCollection AddDomainCoreModule(this IServiceCollection services)
        {
            services.AddScoped<IDomainNotificationSerivce, DomainNotificationService>();
            services.AddMediatR(typeof(DomainNotificationEvent));
            return services;
        }
    }
}
