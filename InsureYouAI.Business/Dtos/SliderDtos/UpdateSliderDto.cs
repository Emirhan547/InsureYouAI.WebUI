using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.SliderDtos
{
    public class UpdateSliderDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
