using HackerRank.Solutions.Contracts;
using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Library.Implementation
{
    public class GradingStudents : BaseSolution, ISolution
    {
        public string Title => "Grading Students";

        public HackerRankProblem Id => HackerRankProblem.GradingStudents;


        public List<int> Answer(List<int> grades)
        {
            for (var i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    continue;
                }

                var nearstMultiple = grades[i] / 5;
                var diff = 5 - (grades[i] % nearstMultiple);

                if (diff < 3)
                {
                    grades[i] = ((grades[i] / 5) + 1) * 5;
                }
            }

            return grades;
        }


        public void Execute()
        {
            var grades = new List<int> { 73, 67, 38, 33 };
            var result = Answer(grades);

            PrintAnswer(Title, string.Join(' ', result));
        }
    }
}
