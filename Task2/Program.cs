

Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the operation: ");
string operation = Console.ReadLine();

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Calculator calculator = new Calculator(num1, num2);

switch (operation)
{
    case "+":
        Console.WriteLine($"{num1} + {num2} = {calculator.Sum()}");
        break;

    case "-":
        Console.WriteLine($"{num1} - {num2} = {calculator.Subtract()}");
        break;

    case "*":
        Console.WriteLine($"{num1} * {num2} = {calculator.Multiplication()}");
        break;

    case "/":
        Console.WriteLine($"{num1} / {num2} = {calculator.Division()}");
        break;

    default:
        Console.WriteLine("Invalid operation");
        break;
}

Console.WriteLine();

