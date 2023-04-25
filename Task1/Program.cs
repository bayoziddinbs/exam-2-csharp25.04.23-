Console.Write("From: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.Write("To: ");
var b = Convert.ToInt32(Console.ReadLine());



for (int i = a; i <= b; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("{i} x {j} = {i*j}");
    }

    Console.WriteLine();
}

Console.ReadLine();