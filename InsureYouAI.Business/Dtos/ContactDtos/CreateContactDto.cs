using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
