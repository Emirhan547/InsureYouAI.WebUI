using InsureYouAI.Business.Dtos.ContactDtos;
using InsureYouAI.Business.Dtos.MessageDtos;
using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.DataAccess.Repositories.MessageRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.MessageServices
{
    public class MessageService(IMessageRepository _repository) : IMessageService
    {
        public async Task CreateAsync(CreateMessageDto dto)
        {
            var mapped = dto.Adapt<Message>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Message Bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultMessageDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result.Adapt<IList<ResultMessageDto>>();
        }

        public async Task<UpdateMessageDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
            {
                throw new Exception("Message Bulunamadı");
            }
            return result.Adapt<UpdateMessageDto>();
        }

        public async Task UpdateAsync(UpdateMessageDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if (result == null)
            {
                throw new Exception("Message bulunamadı");
            }
            result.Adapt(dto);
            await _repository.UpdateAsync(result);
        }
    }
}
