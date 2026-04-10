using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
