using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.TrailerVideoDtos
{
    public class CreateTrailerVideoDto
    {
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}
