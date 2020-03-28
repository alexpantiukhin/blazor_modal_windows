using Microsoft.Extensions.DependencyInjection;

namespace BlazorModalWindowComponent
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
