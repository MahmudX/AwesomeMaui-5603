using System;
using System.Collections.Generic;
using Models.Base;
using Models.User;

namespace Models.Academic
{
    public class Semester : BaseModel
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
