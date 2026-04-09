using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.AboutDtos
{
    public class CreateAboutDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
