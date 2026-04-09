using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.MessageDtos
{
    public class ResultMessageDto
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
