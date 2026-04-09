using InsureYouAI.Business.Dtos.CategoryDtos;
using InsureYouAI.Business.Dtos.ContactDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.ContactServices
{
    public interface IContactService
    {
        Task<IList<ResultContactDto>> GetAllAsync();
        Task<UpdateContactDto> GetByIdAsync(int id);
        Task CreateAsync(CreateContactDto dto);
        Task UpdateAsync(UpdateContactDto dto);
        Task DeleteAsync(int id);
    }
}
