using InsureYouAI.Business.Dtos.SliderDtos;
using InsureYouAI.DataAccess.Repositories.SliderRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.SliderServices
{
    public class SliderService (ISliderRepository _repository): ISliderService
    {
        public async Task CreateAsync(CreateSliderDto dto)
        {
            var mapped = dto.Adapt<Slider>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var slider=await _repository.GetByIdAsync(id);
            if(slider==null)
            {
                throw new Exception("Slider Bulunamadı");
            }
            await _repository.DeleteAsync(slider);
        }

        public async Task<IList<ResultSliderDto>> GetAllAsync()
        {
            var sliders = await _repository.GetAllAsync();
            return sliders.Adapt<IList<ResultSliderDto>>();
        }

        public async Task<UpdateSliderDto> GetByIdAsync(int id)
        {
            var slider = await _repository.GetByIdAsync(id);
            if (slider == null)
            {
                throw new Exception("Slider Bulunamadı");
            }
            return slider.Adapt<UpdateSliderDto>();
        }

        public async Task UpdateAsync(UpdateSliderDto dto)
        {
            var slider = await _repository.GetByIdAsync(dto.Id);
            if( slider == null)
            {
                throw new Exception("Slider bulunamadı");
            }
            dto.Adapt(slider);
            await _repository.UpdateAsync(slider);
        }
    }
}
