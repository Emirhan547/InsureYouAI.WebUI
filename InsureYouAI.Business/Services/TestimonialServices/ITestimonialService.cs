using InsureYouAI.Business.Dtos.TestimonialDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<IList<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto>GetByIdAsync(int id);
        Task CreateAsync(CreateTestimonialDto dto);
        Task UpdateAsync(UpdateTestimonialDto dto);
        Task DeleteAsync(int id);
    }
}
