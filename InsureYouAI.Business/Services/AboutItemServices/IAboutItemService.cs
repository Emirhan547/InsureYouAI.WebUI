using InsureYouAI.Business.Dtos.AboutItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.AboutItemServices
{
    public interface IAboutItemService
    {
        Task<IList<ResultAboutItemDto>> GetAllAsync();
        Task<UpdateAboutItemDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutItemDto dto);
        Task UpdateAsync(UpdateAboutItemDto dto);
        Task DeleteAsync(int id);
    }
}
