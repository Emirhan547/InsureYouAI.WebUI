using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.AboutItemRepositories
{
    public class AboutItemRepository : GenericRepository<AboutItem>
    {
        public AboutItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
