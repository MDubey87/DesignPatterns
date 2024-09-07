// Example: (3 + 5) - 2
using InterpreterPattern;

Expression expression = new SubtractExpression(
    new AddExpression(
        new NumberExpression(3),
        new NumberExpression(5)
    ),
    new NumberExpression(2)
);

Console.WriteLine($"Result: {expression.Interpret()}");
Console.WriteLine();