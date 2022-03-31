using System;
using Models.Base;
using Models.User;

namespace Models.Social
{
    public class Message : BaseModel
    {
        public string Content { get; set; }
        public string ConversationId { get; set; }
        public bool IsSent { get; set; }

        public bool IsSentPreviousMessage { get; set; }

        public Message ReplyTo { get; set; }
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
    }
}
