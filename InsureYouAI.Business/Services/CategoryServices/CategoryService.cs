using InsureYouAI.Business.Dtos.ArticleDtos;
using InsureYouAI.Business.Dtos.CategoryDtos;
using InsureYouAI.DataAccess.Repositories.CategoryRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.CategoryServices
{
    public class CategoryService (ICategoryRepository _repository): ICategoryService
    {
        public async Task CreateAsync(CreateCategoryDto dto)
        {
            var mapped = dto.Adapt<Category>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Category Bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultCategoryDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result.Adapt<IList<ResultCategoryDto>>();
        }

        public async Task<UpdateCategoryDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Category Bulunamadı");
            }
            return result.Adapt<UpdateCategoryDto>();
        }

        public async Task UpdateAsync(UpdateCategoryDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if (result == null)
            {
                throw new Exception("Category bulunamadı");
            }
            result.Adapt(dto);
            await _repository.UpdateAsync(result);
        }
    }
}
