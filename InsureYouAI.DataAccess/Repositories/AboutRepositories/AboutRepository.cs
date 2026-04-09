using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.AboutRepositories
{
    public class AboutRepository : GenericRepository<About>
    {
        public AboutRepository(AppDbContext context) : base(context)
        {
        }
    }
}
