using System.Collections.Generic;
using Models.Base;
using Models.Social;

namespace Models.User
{
    public abstract class ApplicationUser : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Concat(FirstName, " ", LastName);
        public string Bio { get; set; }
        public int NumberOfConversations { get; set; }
        public int NumberOfMessagesSent { get; set; }
        public string ProfilePic { get; set; }
        public bool IsOnline { get; set; }
        protected ApplicationUser()
        {

        }

        public List<Conversation> Conversation { get; set; }

        protected ApplicationUser(string firstName, string secondName, string bio, string profilePic, int numberOfConversations,
            int numberOfMessagesSent)
        {
            FirstName = firstName;
            LastName = secondName;
            NumberOfConversations = numberOfConversations;
            Bio = bio;
            ProfilePic = profilePic;
            NumberOfMessagesSent = numberOfMessagesSent;
        }
    }
}
