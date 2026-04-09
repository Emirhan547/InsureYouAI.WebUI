using InsureYouAI.Business.Dtos.MessageDtos;
using InsureYouAI.Business.Dtos.PricingPlanDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.PricingPlanServices
{
    public interface IPricingPlanService
    {
        Task<IList<ResultPricingPlanDto>> GetAllAsync();
        Task<UpdatePricingPlanDto> GetByIdAsync(int id);
        Task CreateAsync(CreatePricingPlanDto dto);
        Task UpdateAsync(UpdatePricingPlanDto dto);
        Task DeleteAsync(int id);
    }
}
