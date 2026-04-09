using InsureYouAI.Business.Dtos.AboutDtos;
using InsureYouAI.DataAccess.Repositories.AboutRepositories;
using InsureYouAI.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _repository) : IAboutService
    {
        public async Task CreateAsync(CreateAboutDto createAboutDto)
        {
            var abouts = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl,
            };
            await _repository.CreateAsync(abouts);
        }

        public async Task DeleteAsync(int id)
        {
            var abouts=await _repository.GetByIdAsync(id);
            if(abouts is null)
            {
                throw new Exception("About Bulunamadı");
            }
          await _repository.DeleteAsync(abouts);
        }

        public async Task<IList<ResultAboutDto>> GetAllAsync()
        {
            var abouts = await _repository.GetAllAsync();
            var result = abouts.Select(x => new ResultAboutDto
            {
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                Title = x.Title,

            }).ToList();
            return result;
        }        

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            var abouts = await _repository.GetByIdAsync(id);
            if(abouts==null)
            {
                throw new Exception("About Bulunamadı");
            }
            var result = new UpdateAboutDto()
            {
                Id = abouts.Id,
                ImageUrl= abouts.ImageUrl,
                Title = abouts.Title,
                Description = abouts.Description,
            };
            return result;
        }

        public async Task UpdateAsync(UpdateAboutDto updateAboutDto)
        {
            var abouts = await _repository.GetByIdAsync(updateAboutDto.Id);
            if( abouts==null)
            {
                throw new Exception("About bulunamadı");
            }
            abouts.Title = updateAboutDto.Title;
            abouts.ImageUrl = updateAboutDto.ImageUrl;
            abouts.Id = updateAboutDto.Id;
            abouts.Description = updateAboutDto.Description;
            await _repository.UpdateAsync(abouts);
        }
    }
}
