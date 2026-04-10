using InsureYouAI.Business.Dtos.ContactDtos;
using InsureYouAI.Business.Dtos.FeatureDtos;
using InsureYouAI.DataAccess.Repositories.FeatureRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.FeatureServices
{
    public class FeatureService (IFeatureRepository _repository): IFeatureService
    {
        public async Task CreateAsync(CreateFeatureDto dto)
        {
            var mapped = dto.Adapt<Feature>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Feature Bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultFeatureDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result.Adapt<IList<ResultFeatureDto>>();
        }

        public async Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Feature Bulunamadı");
            }
            return result.Adapt<UpdateFeatureDto>();
        }

        public async Task UpdateAsync(UpdateFeatureDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if (result == null)
            {
                throw new Exception("Feature bulunamadı");
            }
            result.Adapt(dto);
            await _repository.UpdateAsync(result);
        }
    }
}
