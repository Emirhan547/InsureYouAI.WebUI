using InsureYouAI.Business.Dtos.ArticleDtos;
using InsureYouAI.Business.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<IList<ResultCategoryDto>> GetAllAsync();
        Task<UpdateCategoryDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCategoryDto dto);
        Task UpdateAsync(UpdateCategoryDto dto);
        Task DeleteAsync(int id);
    }
}
