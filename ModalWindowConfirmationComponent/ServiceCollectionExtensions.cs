using Microsoft.Extensions.DependencyInjection;

namespace ModalWindowConfirmationComponent
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWindowConfirmation(this IServiceCollection services)
        {
            return services.AddScoped<WindowConfirmationServices>();
        }
    }
}
