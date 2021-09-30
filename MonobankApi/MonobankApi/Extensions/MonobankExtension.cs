using Microsoft.Extensions.DependencyInjection;
namespace MonobankApi.Extensions
{
    public static class MonobankExtension
    {
        public static void AddMonobankServices(this IServiceCollection services, string token = null)
        {
            services.AddSingleton<IMonobankService, MonobankService>(x => new MonobankService(token));
        }
    }
}