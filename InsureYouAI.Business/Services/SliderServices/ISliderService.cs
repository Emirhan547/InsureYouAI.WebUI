using InsureYouAI.Business.Dtos.SliderDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.SliderServices
{
    public interface ISliderService
    {
        Task<IList<ResultSliderDto>> GetAllAsync();
        Task<UpdateSliderDto> GetByIdAsync(int id);
        Task CreateAsync(CreateSliderDto dto);
        Task UpdateAsync(UpdateSliderDto dto);
        Task DeleteAsync(int id);
    }
}
