using InsureYouAI.DataAccess.Repositories.AboutItemRepositories;
using InsureYouAI.DataAccess.Repositories.AboutRepositories;
using InsureYouAI.DataAccess.Repositories.ArticleRepositories;
using InsureYouAI.DataAccess.Repositories.CategoryRepositories;
using InsureYouAI.DataAccess.Repositories.ContactRepositories;
using InsureYouAI.DataAccess.Repositories.FeatureRepositories;
using InsureYouAI.DataAccess.Repositories.MessageRepositories;
using InsureYouAI.DataAccess.Repositories.PricingPlanRepositories;
using InsureYouAI.DataAccess.Repositories.SliderRepositories;
using InsureYouAI.DataAccess.Repositories.TestimonialRepositories;
using InsureYouAI.DataAccess.Repositories.TrailerVideoRepositories;
using InsureYouAI.WebUI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Extensions
{
    public static class RepositoryRegistration
    {
        public static IServiceCollection AddRepositoriesExt(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<IAboutItemRepository,AboutItemRepository>();
            services.AddScoped<IAboutRepository,AboutRepository>();
            services.AddScoped<IArticleRepository,ArticleRepository>();
            services.AddScoped<IContactRepository,ContactRepository>();
            services.AddScoped<IFeatureRepository,FeatureRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IMessageRepository,MessageRepository>();
            services.AddScoped<IPricingPlanRepository,PricingPlanRepository>();
            services.AddScoped<ISliderRepository,SliderRepository>();
            services.AddScoped<ITestimonialRepository,TestimonialRepository>();
            services.AddScoped<ITrailerVideoRepository,TrailerVideoRepository>();


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
