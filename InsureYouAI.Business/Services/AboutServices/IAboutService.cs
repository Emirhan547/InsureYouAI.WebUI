using InsureYouAI.Business.Dtos.AboutDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.AboutServices
{
    public interface IAboutService
    {
        Task<IList<ResultAboutDto>> GetAllAsync();
        Task CreateAsync(CreateAboutDto createAboutDto);
        Task UpdateAsync(UpdateAboutDto updateAboutDto);
        Task<UpdateAboutDto>GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
