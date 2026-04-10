using InsureYouAI.Business.Dtos.TrailerVideoDtos;
using InsureYouAI.DataAccess.Repositories.TrailerVideoRepositories;
using InsureYouAI.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Services.TrailerVideoServices
{
    public class TrailerVideoService(ITrailerVideoRepository _repository) : ITrailerVideoService
    {
        public async Task CreateAsync(CreateTrailerVideoDto dto)
        {
            var mapped = dto.Adapt<TrailerVideo>();
            await _repository.CreateAsync(mapped);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if(result == null)
            {
                throw new Exception("TrailerVideo bulunamadı");
            }
            await _repository.DeleteAsync(result);
        }

        public async Task<IList<ResultTrailerVideoDto>> GetAllAsync()
        {
            var result=await _repository.GetAllAsync();
            return result.Adapt<IList<ResultTrailerVideoDto>>();
        }

        public async Task<UpdateTrailerVideoDto> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if(result == null)
            {
                throw new Exception("TrailerVideo bulunamadı");
            }
            return result.Adapt<UpdateTrailerVideoDto>();
        }

        public async Task UpdateAsync(UpdateTrailerVideoDto dto)
        {
            var result = await _repository.GetByIdAsync(dto.Id);
            if( result == null)
            {
                throw new Exception("TrailerVideo bulunamadı");
            }
            dto.Adapt(result);
            await _repository.UpdateAsync(result);
        }
    }
}
