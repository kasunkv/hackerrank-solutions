using HackerRank.Solutions.Contracts;

namespace HackerRank.Solutions.Library.Warnup
{
    public class VeryBigSum : BaseSolution, ISolution
    {
        public string Title => "Very Big Sum";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.VeryBigSum;

        public long Answer(List<long> arr)
        {
            return arr.Sum();
        }


        public void Execute()
        {
            var arr = new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            var result = Answer(arr);

            PrintAnswer(Title, result.ToString());
        }
    }
}
