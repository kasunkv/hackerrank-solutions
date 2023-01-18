using HackerRank.Solutions.Contracts;
using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Library.Implementation
{
    public class NumberLineJumps : BaseSolution, ISolution
    {
        public string Title => "Number Line Jumps";

        public HackerRankProblem Id => HackerRankProblem.NumberLineJumps;


        public string Answer(int x1, int v1, int x2, int v2)
        {
            int x1Distance = x1;
            int x2Distance = x2;

            for (int i = 0; i < 10000; i++)
            {
                x1Distance += v1;
                x2Distance += v2;

                if (x1Distance == x2Distance)
                {
                    return "YES";
                }
            }

            return "NO";
        }


        public void Execute()
        {
            var result = Answer(0, 3, 4, 2);

            PrintAnswer(Title, result);
        }
    }
}
