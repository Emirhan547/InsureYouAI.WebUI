using InsureYouAI.Business.Dtos.FeatureDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<IList<ResultFeatureDto>> GetAllAsync();
        Task<UpdateFeatureDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFeatureDto dto);
        Task UpdateAsync(UpdateFeatureDto dto);
        Task DeleteAsync(int id);
    }
}
