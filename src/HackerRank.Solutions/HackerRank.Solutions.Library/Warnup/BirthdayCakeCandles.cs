using HackerRank.Solutions.Contracts;
using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Library.Warnup
{
    public class BirthdayCakeCandles : BaseSolution, ISolution
    {
        public string Title => "Birthday Cake Candles";

        public HackerRankProblem Id => HackerRankProblem.BirthdayCakeCandles;


        public int Answer(List<int> candles)
        {
            var candleDict = new Dictionary<int, int>();
            int tallest = 0;

            for (var i = 0; i < candles.Count; i++)
            {
                if (!candleDict.TryAdd(candles[i], 1))
                {
                    candleDict[candles[i]] += 1;
                }

                if (candles[i] > tallest)
                {
                    tallest = candles[i];
                }
            }

            return candleDict[tallest];
        }

        public void Execute()
        {
            var candles = new List<int> { 3, 2, 1, 3 };
            var result = Answer(candles);

            PrintAnswer(Title, result.ToString());
        }
    }
}
