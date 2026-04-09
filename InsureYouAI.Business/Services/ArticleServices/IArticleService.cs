using InsureYouAI.Business.Dtos.ArticleDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.ArticleServices
{
    public interface IArticleService
    {
        Task<IList<ResultArticleDto>> GetAllAsync();
        Task<UpdateArticleDto> GetByIdAsync(int id);
        Task CreateAsync(CreateArticleDto articleDto);
        Task UpdateAsync(UpdateArticleDto articleDto);
        Task DeleteAsync(int id);
    }
}
