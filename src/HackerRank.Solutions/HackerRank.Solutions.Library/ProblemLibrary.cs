using HackerRank.Solutions.Contracts;
using HackerRank.Solutions.Library.Warnup;
using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Library
{
    public class ProblemLibrary
    {
        public Dictionary<HackerRankProblem, ISolution> Problems { get; private set; }

        public List<string> ProblemTitles => Problems.Values.Select(p => p.Title).ToList();

        public List<HackerRankProblem> ProblemIds => Problems.Keys.ToList();

        public ProblemLibrary()
        {
            Problems = new Dictionary<HackerRankProblem, ISolution>
            {
                { HackerRankProblem.SolveMeFirst, new SolveMeFirst() },
                { HackerRankProblem.SimpleArraySum, new SimpleArraySum() },
                { HackerRankProblem.VeryBigSum, new VeryBigSum() },
                { HackerRankProblem.DiagonalDifference, new DiagonalDifference() },
            };
        }
    }
}
