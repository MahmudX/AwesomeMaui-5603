using System;

namespace Models.Academic
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public float Credit { get; set; }
        public bool IsActive { get; set; } = true;
        public override string ToString()
        {
            return Name;
        }
    }
}
