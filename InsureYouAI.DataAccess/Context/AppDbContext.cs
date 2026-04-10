
using InsureYouAI.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.WebUI.Context
{
    public class AppDbContext(DbContextOptions options):DbContext(options)
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PricingPlan> PricingPlans { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TrailerVideo> TrailerVideos { get; set; }
    }
}
