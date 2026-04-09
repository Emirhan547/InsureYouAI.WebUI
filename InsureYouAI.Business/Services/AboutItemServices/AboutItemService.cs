using InsureYouAI.Business.Dtos.AboutItems;
using InsureYouAI.DataAccess.Repositories.AboutItemRepositories;
using InsureYouAI.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _repository) : IAboutItemService
    {
        public async Task CreateAsync(CreateAboutItemDto dto)
        {

            await _repository.CreateAsync(new AboutItem{ Detail = dto.Detail});
        }

        public async Task DeleteAsync(int id)
        {
            var aboutItems=await _repository.GetByIdAsync(id);
            if (aboutItems == null)
            {
                throw new Exception("AboutItem Bulunamadı");
            }
            await _repository.DeleteAsync(aboutItems);
        }

        public async Task<IList<ResultAboutItemDto>> GetAllAsync()
        {
            var aboutItems = await _repository.GetAllAsync();
            return aboutItems.Select(x => new ResultAboutItemDto(x.Id, x.Detail)).ToList();
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            var aboutItem = await _repository.GetByIdAsync(id);

            if (aboutItem is null)
            {
                throw new KeyNotFoundException($"AboutItem ({id}) bulunamadı");
            }

            return new UpdateAboutItemDto(aboutItem.Id, aboutItem.Detail);

        }

        public async Task UpdateAsync(UpdateAboutItemDto dto)
        {
            var aboutItems = await _repository.GetByIdAsync(dto.Id);
            if(aboutItems is null)
            {
                throw new Exception("AboutsItem bulunamadı");
            }
            aboutItems.Detail = dto.Detail;
            await _repository.UpdateAsync(aboutItems);
        }
    }
}
