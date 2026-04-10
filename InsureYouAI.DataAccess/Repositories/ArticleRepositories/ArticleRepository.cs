using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.ArticleRepositories
{
    public class ArticleRepository : GenericRepository<Article>,IArticleRepository
    {
        public ArticleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
