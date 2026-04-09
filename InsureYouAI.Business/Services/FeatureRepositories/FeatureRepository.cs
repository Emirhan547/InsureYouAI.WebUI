using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.FeatureRepositories
{
    public class FeatureRepository(AppDbContext context):GenericRepository<Feature>(context)
    {
    }
}
