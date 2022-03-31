using Educial.Services;
using Models.Academic;
using System.Collections.ObjectModel;

namespace Educial.ViewModels.Dashboard.Result
{
    public class CurrentStatusViewModel : BaseViewModel
    {
        public ObservableCollection<ResultBySubject> ResultBySubjects { get; set; }

        public CurrentStatusViewModel()
        {
            Title = "Portal";
            List<Subject> subjects = new List<Subject>()
            {
                new Subject()
                {
                    Code = "CSE-325", Name = "E-Commerce and Web Programming",
                    Credit = 3
                },
                new Subject()
                {
                    Code = "CSE-324", Name = "Computer Architecture Lab",
                    Credit = 1
                },
                new Subject
                {
                    Code = "CSE-323", Name = "Computer Architecture",
                    Credit = 3
                },
                new Subject
                {
                    Code = "CSE-321", Name = "Theory of Computation and Compiler Design",
                    Credit = 3
                },
                new Subject
                {
                    Code = "LAW-321", Name = "Cyber and Intellectual Property Laws",
                    Credit = 2
                },
                new Subject
                {
                    Code = "CSE-326", Name = "E-Commerce and Web Programming Lab",
                    Credit = 1
                },
            };
            ResultBySubjects = new ObservableCollection<ResultBySubject>(new List<ResultBySubject>
            {
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="CSE-325"),
                    Grade = ResultGrade.APlus.GetDescription(),
                    Point = 4
                },
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="CSE-324"),
                    Grade = ResultGrade.APlus.GetDescription(),
                    Point = 4
                },
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="CSE-323"),
                    Grade = ResultGrade.AMin.GetDescription(),
                    Point = 3.50F
                },
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="CSE-321"),
                    Grade = ResultGrade.A.GetDescription(),
                    Point = 3.75F
                },
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="LAW-321"),
                    Grade = ResultGrade.B.GetDescription(),
                    Point = 3
                },
                new ResultBySubject()
                {
                    Subject = subjects.FirstOrDefault(s=>s.Code=="CSE-326"),
                    Grade = ResultGrade.APlus.GetDescription(),
                    Point = 4
                }
            });
        }
    }
}
