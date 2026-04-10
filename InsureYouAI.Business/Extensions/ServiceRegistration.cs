using InsureYouAI.Business.Services.AboutItemServices;
using InsureYouAI.Business.Services.AboutServices;
using InsureYouAI.Business.Services.ArticleServices;
using InsureYouAI.Business.Services.CategoryServices;
using InsureYouAI.Business.Services.ContactServices;
using InsureYouAI.Business.Services.FeatureServices;
using InsureYouAI.Business.Services.MessageServices;
using InsureYouAI.Business.Services.PricingPlanServices;
using InsureYouAI.Business.Services.SliderServices;
using InsureYouAI.Business.Services.TestimonialServices;
using InsureYouAI.Business.Services.TrailerVideoServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServicesExt(this IServiceCollection services)
        {
            services.AddScoped<IAboutItemService, AboutItemService>();
            services.AddScoped<IAboutService,AboutService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IPricingPlanService, PricingPlanService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<ITrailerVideoService, TrailerVideoService>();

            return services;
        }
    }
}
