using HackerRank.Solutions.Contracts;


namespace HackerRank.Solutions.Library.Warnup
{
    public class MinMaxSum : BaseSolution, ISolution
    {
        public string Title => "Min Max Sum";

        public Shared.HackerRankProblem Id => Shared.HackerRankProblem.MinMaxSum;


        public string Answer(List<int> arr)
        {
            double minTotal = 0;
            double maxTotal = 0;

            arr.Sort();


            foreach (var item in arr.Select((Value, Index) => new { Index, Value }))
            {
                if (item.Index != 0)
                {
                    maxTotal += item.Value;
                }

                if (item.Index != arr.Count - 1)
                {
                    minTotal += item.Value;
                }
            }

            return $"{minTotal} {maxTotal}";
        }

        public void Execute()
        {
            var arr = new List<int> { 793810624, 895642170, 685903712, 623789054, 468592370, };
            //var arr = new List<int> { 5, 5, 5, 5, 5, };


            var result = Answer(arr);

            PrintAnswer(Title, result);
        }
    }
}
