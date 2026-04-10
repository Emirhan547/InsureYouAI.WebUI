using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.TrailerVideoRepositories
{
    public class TrailerVideoRepository(AppDbContext context) : GenericRepository<TrailerVideo>(context),ITrailerVideoRepository
    {
    }
}
