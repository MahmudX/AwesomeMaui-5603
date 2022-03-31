using Models.Academic;
using System.Collections.ObjectModel;

namespace Educial.ViewModels.Dashboard.Result
{
    public class ResultArchiveViewModel : BaseViewModel
    {
        public ObservableCollection<SemesterResult> SemesterResults { get; set; }
        public ResultArchiveViewModel()
        {
            //TODO: Remove generated list
            var cv = new CurrentStatusViewModel();

            SemesterResults = new ObservableCollection<SemesterResult>(new List<SemesterResult>())
            {
                new SemesterResult()
                {
                    ResultBySubject = cv.ResultBySubjects.ToList(),
                    Semester =new Semester(){Name = "1st Semester"}
                },
                new SemesterResult()
                {
                    ResultBySubject = cv.ResultBySubjects.ToList(),
                    Semester =new Semester(){Name = "2nd Semester"}
                },
                new SemesterResult()
                {
                    ResultBySubject = cv.ResultBySubjects.ToList(),
                    Semester =new Semester(){Name = "3rd Semester"}
                }
            };
            Title = "Result Archive";
        }
    }
}
