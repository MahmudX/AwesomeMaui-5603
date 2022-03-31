using Models.Academic;

namespace Models.User
{
    public class Student : ApplicationUser
    {
        public string Email { get; set; }
        public Semester Semester { get; set; }
        public ResultArchive ResultArchive { get; set; }

        public Student()
        {
            
        }

        public Student(string firstName, string secondName, string bio, string profilePic, int numberOfConversations,
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
