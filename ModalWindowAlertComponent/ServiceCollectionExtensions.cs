using Microsoft.Extensions.DependencyInjection;

namespace ModalWindowAlertComponent
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWindowAlert(this IServiceCollection services)
        {
            return services.AddScoped<WindowAlertServices>();
        }
    }
}
