Console.Write("Enter the first number: ");
var arg1 = Console.ReadLine();
double.TryParse(arg1, out var num1);

Console.Write("Enter the second number: ");
var arg2 = Console.ReadLine();
double.TryParse(arg2, out var num2);

Console.Write("Enter an operator (+, -, *, /): ");
var op = Console.ReadLine();

var result = 0.0d;

switch (op)
{
    case "+":
        result = num1 + num2;
        break;
    default:
        Console.WriteLine("Invalid operator.");
        return;
}
Console.WriteLine("Result: " + result);
