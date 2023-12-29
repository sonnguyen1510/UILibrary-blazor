

using Microsoft.Extensions.DependencyInjection;
using UILibrary.Service;

namespace UILibrary
{
    public static class config 
    {
        public static IServiceCollection AddUILibrary(this IServiceCollection services)
        {
            services.AddScoped<DatePickerService>();


            return services;
        }
        
    }
}
