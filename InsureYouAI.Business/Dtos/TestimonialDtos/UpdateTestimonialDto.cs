using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string CommentDetail { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
