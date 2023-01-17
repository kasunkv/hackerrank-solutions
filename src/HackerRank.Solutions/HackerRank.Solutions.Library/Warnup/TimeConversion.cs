using HackerRank.Solutions.Contracts;
using HackerRank.Solutions.Shared;

namespace HackerRank.Solutions.Library.Warnup
{
    public class TimeConversion : BaseSolution, ISolution
    {
        public string Title => "Time Conversion";

        public HackerRankProblem Id => HackerRankProblem.TimeConversion;


        public string Answer(string s)
        {
            var format = s.Substring(s.Length - 2);
            var time = s.Substring(0, s.Length - 2);
            var timeSegments = time.Split(':');
            var hour = int.Parse(timeSegments[0]);

            if (format == "AM")
            {
                timeSegments[0] = (hour % 12).ToString().PadLeft(2, '0');
            }
            else
            {
                timeSegments[0] = (hour % 12 + 12).ToString().PadLeft(2, '0');
            }

            return string.Join(':', timeSegments);
        }


        public void Execute()
        {
            string time = "12:45:54AM";
            var result = Answer(time);

            PrintAnswer(Title, result);
        }
    }
}
