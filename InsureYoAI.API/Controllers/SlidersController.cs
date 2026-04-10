using InsureYouAI.Business.Dtos.FeatureDtos;
using InsureYouAI.Business.Dtos.SliderDtos;
using InsureYouAI.Business.Services.SliderServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsureYoAI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController (ISliderService _service): ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSliderDto create)
        {
            await _service.CreateAsync(create);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateSliderDto update)
        {
            await _service.UpdateAsync(update);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
