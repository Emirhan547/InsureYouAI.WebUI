using InsureYouAI.Business.Dtos.ContactDtos;
using InsureYouAI.Business.Dtos.MessageDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.MessageServices
{
    public interface IMessageService
    {
        Task<IList<ResultMessageDto>> GetAllAsync();
        Task<UpdateMessageDto> GetByIdAsync(int id);
        Task CreateAsync(CreateMessageDto dto);
        Task UpdateAsync(UpdateMessageDto dto);
        Task DeleteAsync(int id);
    }
}
