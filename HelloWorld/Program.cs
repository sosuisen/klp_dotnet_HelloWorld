Console.Write("Enter the first number: ");
string? arg1 = Console.ReadLine();
double.TryParse(arg1, out double num1);

Console.Write("Enter the second number: ");
string? arg2 = Console.ReadLine();
double.TryParse(arg2, out double num2);

Console.Write("Enter an operator (+, -, *, /): ");
string? op = Console.ReadLine();

double result = 0;

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
