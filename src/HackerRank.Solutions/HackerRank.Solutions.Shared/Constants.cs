using System.ComponentModel;

namespace HackerRank.Solutions.Shared
{
    public enum HackerRankProblem
    {
        SolveMeFirst = 1,
        SimpleArraySum = 2,
        VeryBigSum = 3,
        DiagonalDifference = 4,
        PlusMinus = 5,
        Staircase = 6,
        MinMaxSum = 7,
        BirthdayCakeCandles = 8,
        TimeConversion = 9,
        GradingStudents = 10,
    }

    public enum ProgramOperations
    {
        [Description("Select Problem")]
        SelectProblem = 1,

        [Description("Exit")]
        Exit = 2
    }
}
