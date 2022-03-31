using System;

namespace Models.Academic
{
    public class ResultBySubject
    {
        public Guid Id { get; set; }
        public Subject Subject { get; set; }
        public float Point { get; set; }
        public string Grade { get; set; }
    }
}
