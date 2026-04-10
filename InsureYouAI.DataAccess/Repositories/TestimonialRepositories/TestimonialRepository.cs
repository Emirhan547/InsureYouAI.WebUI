using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>,ITestimonialRepository
    {
        public TestimonialRepository(AppDbContext context) : base(context)
        {
        }
    }
}
