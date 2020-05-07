using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nianemisArtSite.Config.Extensions
{
    public static class ConfigProvider
    {
        public static void AddConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfigContent>(new ConfigContent
            { 
                About = configuration.GetSection("PathImg")["about"],
                Digital = configuration.GetSection("PathImg")["digital"],
                Drawings = configuration.GetSection("PathImg")["drawings"]
            });
        }
    }
}
