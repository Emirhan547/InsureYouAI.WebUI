using InsureYouAI.Business.Dtos.AboutItems;
using InsureYouAI.Business.Services.AboutItemServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsureYoAI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemsController(IAboutItemService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto create)
        {
            await _service.CreateAsync(create);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto update)
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
    }
}
