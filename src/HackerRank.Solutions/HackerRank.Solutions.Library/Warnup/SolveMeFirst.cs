using HackerRank.Solutions.Contracts;

namespace HackerRank.Solutions.Library.Warnup
{
    public class SolveMeFirst : BaseSolution, ISolution
    {
        public string Title => "Solve Me First";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.SolveMeFirst;


        public int Answer(int a, int b)
        {
            return a + b;
        }


        public void Execute()
        {
            int input1 = 2;
            int input2 = 3;

            var result = Answer(input1, input2);

            PrintAnswer(Title, result.ToString());
        }
    }
}
