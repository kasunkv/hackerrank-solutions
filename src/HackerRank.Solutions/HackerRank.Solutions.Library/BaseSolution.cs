using Spectre.Console;

namespace HackerRank.Solutions.Library
{
    public class BaseSolution
    {
        public void PrintAnswer(string problemTitle, string value)
        {
            AnsiConsole.MarkupLine($"[gold3_1]Answer for {problemTitle} is, [/]");
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"[orange3]{value}[/]");
            AnsiConsole.WriteLine();
        }
    }
}
