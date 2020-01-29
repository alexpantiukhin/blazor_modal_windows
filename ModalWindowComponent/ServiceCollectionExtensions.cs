using Microsoft.Extensions.DependencyInjection;

using ModalWindowAlertComponent;

using ModalWindowConfirmationComponent;

namespace ModalWindowComponent
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorModal(this IServiceCollection services)
        {
            return services.AddScoped<ModalWindowService>();
        }
        public static IServiceCollection AddWindowConfirmation(this IServiceCollection services)
        {
            return services.AddScoped<WindowConfirmationServices>();
        }
        public static IServiceCollection AddWindowAlert(this IServiceCollection services)
        {
            return services.AddScoped<WindowAlertServices>();
        }
    }
}
