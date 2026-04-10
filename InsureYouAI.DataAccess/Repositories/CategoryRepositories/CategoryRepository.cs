using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.CategoryRepositories
{
    public class CategoryRepository(AppDbContext context) : GenericRepository<Category>(context),ICategoryRepository
    {
    }
}
