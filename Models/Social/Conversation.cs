using Models.Base;
using Models.User;

namespace Models.Social
{
    public class Conversation : BaseModel
    {
        public string[] UserIds { get; set; }
        private Message lastMessage;
        public Message LastMessage
        {
            get => lastMessage;
            set => SetProperty(ref lastMessage, value);
        }
        ApplicationUser peer;
        public User.ApplicationUser Peer
        {
            get => peer;
            set => SetProperty(ref peer, value);
        }

        public Conversation()
        {
            UserIds = new string[2];
        }
    }
}
