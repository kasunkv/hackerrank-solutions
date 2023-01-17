using HackerRank.Solutions.Contracts;
using System.Text;

namespace HackerRank.Solutions.Library.Warnup
{
    public class PlusMinus : BaseSolution, ISolution
    {
        public string Title => "Plus Minus";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.PlusMinus;


        public List<string> Answer(List<int> arr)
        {
            var count = arr.Count;
            int positive = 0;
            int negative = 0;
            int zero = 0;

            foreach (var c in arr)
            {
                if (c > 0)
                {
                    positive++;
                }
                else if (c < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            return new List<string>
            {
                string.Format("{0:N6}", (double)positive / count),
                string.Format("{0:N6}", (double)negative / count),
                string.Format("{0:N6}", (double)zero / count),
            };
        }


        public void Execute()
        {
            var arr = new int[] { -4, 3, -9, 0, 4, 1 };

            var result = Answer(arr.ToList());

            var sb = new StringBuilder();
            result.ForEach(str => sb.AppendLine(str));

            PrintAnswer(Title, sb.ToString());

        }
    }
}
