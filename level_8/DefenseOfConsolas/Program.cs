Console.Title = "Defense Of Consolas";

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int col = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({row}, {col - 1})");
Console.WriteLine($"({row - 1}, {col})");
Console.WriteLine($"({row}, {col + 1})");
Console.WriteLine($"({row + 1}, {col})");

Console.Beep();