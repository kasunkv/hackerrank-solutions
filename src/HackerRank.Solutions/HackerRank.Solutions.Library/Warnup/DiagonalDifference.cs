using HackerRank.Solutions.Contracts;

namespace HackerRank.Solutions.Library.Warnup
{
    public class DiagonalDifference : BaseSolution, ISolution
    {
        public string Title => "Diagonal Diffeence";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.DiagonalDifference;


        public static int Answer(List<List<int>> arr)
        {
            var size = arr.Count;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[size - 1 - i][i];
            }


            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }



        public void Execute()
        {
            List<List<int>> arr = new List<List<int>>
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6, },
                new List<int> { 10, 8, -12 }
            };

            int result = Answer(arr);

            PrintAnswer(Title, result.ToString());
        }
    }
}
