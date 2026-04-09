using InsureYouAI.Business.Dtos.ArticleDtos;
using InsureYouAI.DataAccess.Repositories.ArticleRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.ArticleServices
{
    public class ArticleService (IArticleRepository _repository): IArticleService
    {
        public async Task CreateAsync(CreateArticleDto articleDto)
        {
            var article = articleDto.Adapt<Article>();
            await _repository.CreateAsync(article);
        }

        public async Task DeleteAsync(int id)
        {
            var article=await _repository.GetByIdAsync(id);
            if (article == null)
            {
                throw new Exception("Article Bulunamadı");
            }
            await _repository.DeleteAsync(article);
        }

        public async Task<IList<ResultArticleDto>> GetAllAsync()
        {
            var article = await _repository.GetAllAsync();
            return article.Adapt<IList<ResultArticleDto>>();
        }

        public async Task<UpdateArticleDto> GetByIdAsync(int id)
        {
            var article = await _repository.GetByIdAsync(id);
            if(article == null)
            {
                throw new Exception("Article Bulunamadı");
            }
            return article.Adapt<UpdateArticleDto>();
        }

        public async Task UpdateAsync(UpdateArticleDto articleDto)
        {
            var article = await _repository.GetByIdAsync(articleDto.Id);
            if (article == null)
            {
                throw new Exception("Article bulunamadı");
            }
            article.Adapt(articleDto);
            await _repository.UpdateAsync(article);
        }
    }
}
