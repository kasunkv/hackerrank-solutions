using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Contracts
{
    public interface ISolution
    {
        string Title { get; }

        HackerRankProblem Id { get; }

        /// <summary>
        /// Performs the test data setup for the given solution and calls the Answer() method of the
        /// corrosponding solution
        /// </summary>
        void Execute();
    }
}
