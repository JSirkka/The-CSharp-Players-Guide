

using System.Text;
using static System.Net.Mime.MediaTypeNames;

int cityMaxHealth = 15;
int manticoreMaxHealth = 10;

int cityHealth = cityMaxHealth;
int manticoreHealth = manticoreMaxHealth;

int targetDist;

while (true)
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");

    targetDist = Convert.ToInt32(Console.ReadLine());

    if (targetDist >= 0 && targetDist <= 100)
    {
        break;
    }

    Console.WriteLine($"{targetDist} not between 0  and 100. Try again.");
}

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");

int roundNum = 1;

while (true)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundNum}  City: {cityHealth}/{cityMaxHealth}  Manticore: {manticoreHealth}/{manticoreMaxHealth}");
    int cannonDamage = calculateCannonDamage(roundNum);
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");

    Console.Write("Enter desired cannon range: ");
    int distGuess = Convert.ToInt32(Console.ReadLine());

    

    if (distGuess < targetDist)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (distGuess > targetDist)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (distGuess == targetDist)
    {
        manticoreHealth -= cannonDamage;
        writeInColor("That round was a DIRECT HIT!", ConsoleColor.Blue, ConsoleColor.Yellow);
    }

    if (manticoreHealth <= 0 || cityHealth <= 0)
    {
        if (manticoreHealth <= 0)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }

        else if (cityHealth <= 0)
        {
            Console.WriteLine("The Manticore has destroyed the city!");
        }
        
        break;
    }

    cityHealth--;
    roundNum++;

}


int calculateCannonDamage(int roundNum)
{
    int damage = 1;
    if ((roundNum % 5 == 0) && (roundNum % 3 == 0)) damage = 10;
    else if ((roundNum % 5 == 0) || (roundNum % 3 == 0)) damage = 3;

    return damage;
}




void writeInColor(string text, ConsoleColor backColor, ConsoleColor foreColor)
{
    Console.BackgroundColor = backColor;
    Console.ForegroundColor = foreColor;

    Console.WriteLine(text);

    Console.ResetColor();
}