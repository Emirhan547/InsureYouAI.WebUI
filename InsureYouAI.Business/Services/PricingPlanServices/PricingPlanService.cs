using InsureYouAI.Business.Dtos.MessageDtos;
using InsureYouAI.Business.Dtos.PricingPlanDtos;
using InsureYouAI.DataAccess.Repositories.PricingPlanRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.PricingPlanServices
{
    public class PricingPlanService(IPricingPlanRepository _repository) : IPricingPlanService
    {
        public async Task CreateAsync(CreatePricingPlanDto dto)
        {
            var mapped = dto.Adapt<PricingPlan>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("PricingPlan Bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultPricingPlanDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result.Adapt<IList<ResultPricingPlanDto>>();
        }

        public async Task<UpdatePricingPlanDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("PricingPlan Bulunamadı");
            }
            return result.Adapt<UpdatePricingPlanDto>();
        }

        public async Task UpdateAsync(UpdatePricingPlanDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if (result == null)
            {
                throw new Exception("PricingPlan bulunamadı");
            }
            result.Adapt(dto);
            await _repository.UpdateAsync(result);
        }
    }
}
