# HackerRank Solutions - C#

The repository contains the implementations for the HackerRank problems. Follow the instructions below to run the console application and execute the solutions.

## Running the Solution

1. Set the `HackerRank.Solutions.Runner` project as the startup project.
2. Build and run the project.
3. Select the problem title to execute and get the answer.

## Solution Structure

The `HackerRank.Solutions.Library` contains the implementations. Each solution implements the `ISolution` interface that contains the contract for `void Execute()` method that is used to setup test data and exexute the solution and prints out the output.
The implementation for the problem is contained inside of the `Answer()` method in the class.

### Adding a New Implementation

1. Add a new file class to the `HackerRank.Solution.Library` project and inherit from the `BaseSolution` class and implement the `ISolution` interface.
2. Implement the class by adding the `Answer()` method with the solution, `void Execute()` method with the test data, execution and printing the result and set the `Title` property with the display name for the solution and `Id` property with the `HackerRankProblem` enum
3. Add a new enum entry to the `HackerRankProblem` enum in the `HackerRank.Solution.Shared` project with the int value.
4. Add a new entry to the `Dictionary<HackerRankProblem, ISolution>` dictionary in the `ProblemLibrary` class constructor to include the implementation in the program.