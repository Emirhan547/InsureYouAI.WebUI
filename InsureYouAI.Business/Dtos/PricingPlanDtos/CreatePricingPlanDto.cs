using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.PricingPlanDtos
{
    public class CreatePricingPlanDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool IsFeature { get; set; }
    }
}
