Console.WriteLine("Welcome to the Simple Calculator");
Console.WriteLine("--------------------------------");

var simpleCalculator = new SimpleCalculator.SimpleCalculator();

Console.WriteLine($"1 + 5 is {simpleCalculator.Add(1, 5)}");
Console.WriteLine($"2 * 5 is {simpleCalculator.Multiply(2, 5)}");
Console.WriteLine($"12 - 3 is {simpleCalculator.Subtract(12, 3)}");
Console.WriteLine($"6 + 4 is {simpleCalculator.Add(6, 4)}");
Console.WriteLine("--------------------------------");
Console.WriteLine("Bye Bye Simple Calculator!");
Console.WriteLine("A new line from GitHub Codespaces");
