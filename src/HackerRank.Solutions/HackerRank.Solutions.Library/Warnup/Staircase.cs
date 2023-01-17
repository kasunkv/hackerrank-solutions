using HackerRank.Solutions.Contracts;
using System.Text;

namespace HackerRank.Solutions.Library.Warnup
{
    public class Staircase : BaseSolution, ISolution
    {
        public string Title => "Staircase";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.Staircase;



        public List<string> Answer(int n)
        {
            var result = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                var sb = new StringBuilder();
                for (var j = 1; j <= i; j++)
                {
                    sb.Append("#");
                }

                result.Add(sb.ToString().PadLeft(n));
            }

            return result;
        }

        public void Execute()
        {
            int n = 6;

            var result = Answer(n);

            var sb = new StringBuilder();
            result.ForEach(str => sb.AppendLine(str));

            PrintAnswer(Title, sb.ToString());
        }
    }
}
