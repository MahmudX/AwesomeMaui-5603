using System;
using System.Collections.Generic;
using Models.User;

namespace Models.Academic
{
    public class ResultArchive
    {
        public Guid Id { get; set; }
        public Student Student { get; set; }
        public List<SemesterResult> SemesterResults { get; set; }
    }
}
