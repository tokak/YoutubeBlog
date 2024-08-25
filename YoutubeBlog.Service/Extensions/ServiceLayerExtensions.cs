using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;
using YoutubeBlog.Service.FluentValidations;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Conrete;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddAutoMapper(assembly);

          

            services.AddControllersWithViews()
              .AddFluentValidation(opt =>
              {
                  opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                  opt.DisableDataAnnotationsValidation = true;
                  opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
              });
            return services;
        }
    }
}
