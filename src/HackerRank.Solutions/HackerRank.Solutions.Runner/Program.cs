using HackerRank.Solutions.Library;
using HackerRank.Solutions.Shared;
using Spectre.Console;

namespace HackerRank.Solutions.Runner;

public class Program
{
    private static ProblemLibrary _library = new ProblemLibrary();
    private static bool _exitRequested = false;

    public static void Main(string[] args)
    {
        AnsiConsole.Write(
            new FigletText("HackerRank Solutions")
            .LeftJustified()
            .Color(Color.Green3));

        while (!_exitRequested)
        {
            var operation = AnsiConsole.Prompt(new SelectionPrompt<ProgramOperations>()
                .Title("[darkslategray3]Select an operation[/]")
                .PageSize(10)
                .AddChoices(new List<ProgramOperations> { ProgramOperations.SelectProblem, ProgramOperations.Exit })
                .UseConverter(c => $"{(int)c}. {c.ToDescription()}"));

            switch (operation)
            {
                case ProgramOperations.SelectProblem:
                    DisplayProblemsAndExecute();
                    break;
                case ProgramOperations.Exit:
                    DisplayExitPrompt();
                    break;
            }
        }


    }

    public static void DisplayProblemsAndExecute()
    {
        var selection = AnsiConsole.Prompt(new SelectionPrompt<HackerRankProblem>()
            .Title("[darkslategray3]Select the problem to run[/]")
            .PageSize(10)
            .MoreChoicesText("[gray](Move up and down to reveal more problems)[/]")
            .AddChoices(_library.ProblemIds)
            .UseConverter(c => $"{(int)c}. {_library.Problems[c].Title}"));

        var selectedProblem = _library.Problems[selection];

        AnsiConsole.MarkupLine($"[darkslategray3]Executing the solution for '{selectedProblem.Title}'[/]");

        selectedProblem.Execute();
    }

    public static void DisplayExitPrompt()
    {
        if (AnsiConsole.Confirm("[darkred_1]Are you sure you want to exit[/]"))
        {
            _exitRequested = true;
            AnsiConsole.Markup("[palegreen3]Press any key to exit. Thank you.[/]");
            Console.ReadKey();
        }
    }

}