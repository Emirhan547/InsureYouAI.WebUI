using InsureYouAI.Business.Dtos.TestimonialDtos;
using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.DataAccess.Repositories.TestimonialRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.TestimonialServices
{
    public class TestimonialService(ITestimonialRepository _repository) : ITestimonialService
    {
        public async Task CreateAsync(CreateTestimonialDto dto)
        {
            var mapped = dto.Adapt<Testimonial>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var testimonial=await _repository.GetByIdAsync(id);
            if (testimonial == null)
            {
                throw new Exception("Testimonial Bulunamadı");
            }
            await _repository.DeleteAsync(testimonial);
        }

        public async Task<IList<ResultTestimonialDto>> GetAllAsync()
        {
            var testimonial = await _repository.GetAllAsync();
            return testimonial.Adapt<IList<ResultTestimonialDto>>();
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var result=await _repository.GetByIdAsync(id);
            if(result == null)
            {
                throw new Exception("Testimonial bulunamadı");
            }
            return result.Adapt<UpdateTestimonialDto>();
        }

        public async Task UpdateAsync(UpdateTestimonialDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if( result == null)
            {
                throw new Exception("Testimonial bulunamadı");
            }
            var mapped = dto.Adapt(result);
            await _repository.UpdateAsync(mapped);
        }
    }
}
