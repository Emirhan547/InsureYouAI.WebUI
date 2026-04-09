using InsureYouAI.Business.Dtos.CategoryDtos;
using InsureYouAI.Business.Dtos.ContactDtos;
using InsureYouAI.DataAccess.Repositories.ContactRepositories;
using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.ContactServices
{
    public class ContactService (IContactRepository _repository): IContactService
    {
        public async Task CreateAsync(CreateContactDto dto)
        {
            var mapped = dto.Adapt<Contact>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Contact Bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultContactDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result.Adapt<IList<ResultContactDto>>();
        }

        public async Task<UpdateContactDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Contact Bulunamadı");
            }
            return result.Adapt<UpdateContactDto>();
        }

        public async Task UpdateAsync(UpdateContactDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if (result == null)
            {
                throw new Exception("Contact bulunamadı");
            }
            result.Adapt(dto);
            await _repository.UpdateAsync(result);
        }
    }
}
