using HackerRank.Solutions.Contracts;

namespace HackerRank.Solutions.Library.Warnup
{
    public class SimpleArraySum : BaseSolution, ISolution
    {
        public string Title => "Simple Array Sum";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.SimpleArraySum;

        public int Answer(int n, int[] ar)
        {
            int result = 0;
            foreach (var val in ar)
            {
                result += val;
            }
            return result;
        }

        public void Execute()
        {
            int n = 6;
            int[] ar = new int[] { 1, 2, 3, 4, 10, 11 };

            var result = Answer(n, ar);

            PrintAnswer(Title, result.ToString());
        }
    }
}
