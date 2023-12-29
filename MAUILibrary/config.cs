

using Microsoft.Extensions.DependencyInjection;
using MAUILibrary.Service;

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
