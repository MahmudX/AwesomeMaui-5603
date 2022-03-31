using Models.Academic;
using System.Collections.Generic;

namespace Models.User
{
    public class Teacher : ApplicationUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
