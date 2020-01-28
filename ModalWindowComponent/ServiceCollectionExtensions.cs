using Microsoft.Extensions.DependencyInjection;

namespace ModalWindowComponent
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorModal(this IServiceCollection services)
        {
            return services.AddScoped<ModalWindowService>();
        }
    }
}
