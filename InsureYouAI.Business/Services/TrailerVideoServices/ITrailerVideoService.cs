using InsureYouAI.Business.Dtos.TrailerVideoDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.TrailerVideoServices
{
    public interface ITrailerVideoService
    {
        Task<IList<ResultTrailerVideoDto>> GetAllAsync();
        Task<UpdateTrailerVideoDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTrailerVideoDto dto);
        Task UpdateAsync(UpdateTrailerVideoDto dto);
        Task DeleteAsync(int id);
    }
}
