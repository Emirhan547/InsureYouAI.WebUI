using InsureYouAI.Business.Dtos.TrailerVideoDtos;
using InsureYouAI.Business.Services.TrailerVideoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsureYoAI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailerVideosController(ITrailerVideoService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateTrailerVideoDto create)
        {
            await _service.CreateAsync(create);
            return Created();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById (int id)
        {
            var result=await _service.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateTrailerVideoDto update)
        {
            await _service.UpdateAsync(update);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
    }
}
