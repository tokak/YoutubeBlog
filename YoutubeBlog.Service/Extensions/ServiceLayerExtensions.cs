using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Conrete;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
