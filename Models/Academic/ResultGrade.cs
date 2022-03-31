using System.ComponentModel;

namespace Models.Academic
{
    public enum ResultGrade
    {
        [Description("A+")]
        APlus,
        A,
        [Description("A-")]
        AMin,
        [Description("B+")]
        BPlus,
        B,
        [Description("B-")]
        BMin,
        [Description("C+")]
        CPlus,
        C,
        [Description("C-")]
        CMin,
        D,
        F
    }
}
