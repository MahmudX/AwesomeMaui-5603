using System;
using System.Collections.Generic;

namespace Models.Academic
{
    public class SemesterResult
    {
        public Guid Id { get; set; }
        public Semester Semester { get; set; }
        public List<ResultBySubject> ResultBySubject { get; set; }
    }
}
