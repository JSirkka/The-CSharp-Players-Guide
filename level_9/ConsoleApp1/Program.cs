Console.Write("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    if (y > 0) Console.WriteLine("NW");
    else if (y == 0) Console.WriteLine("W");
    else if (y < 0) Console.WriteLine("SW");
}
else if (x == 0)
{
    if (y > 0) Console.WriteLine("N");
    else if (y == 0) Console.WriteLine("!");
    else if (y < 0) Console.WriteLine("S");
}
else if (x > 0)
{
    if (y > 0) Console.WriteLine("NE");
    else if (y == 0) Console.WriteLine("E");
    else if (y < 0) Console.WriteLine("SE");
}