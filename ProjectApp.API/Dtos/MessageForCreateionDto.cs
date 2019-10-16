using System;

namespace ProjectApp.API.Dtos
{
    public class MessageForCreateionDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime MessageSent { get; set; }
        public string Content { get; set; }
        public MessageForCreateionDto()
        {
            MessageSent=DateTime.Now;
        }
    }
}