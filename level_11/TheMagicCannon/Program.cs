





for (int i = 1;i <= 100 ;i++)
{
    string cannonBlast = "";

    if (i % 5 == 0)
    {
        cannonBlast += "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    if (i % 3 == 0)
    {
        cannonBlast += "Fire";
        if (Console.ForegroundColor == ConsoleColor.Yellow)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
            
    }

    if (cannonBlast == "")
    {
        cannonBlast = "Normal";
    }

    Console.WriteLine($"{i}: {cannonBlast}");
    Console.ForegroundColor = ConsoleColor.White;

}