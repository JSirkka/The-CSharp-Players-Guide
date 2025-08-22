
int targetNum;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    targetNum = Convert.ToInt32(Console.ReadLine());

}
while (targetNum < 0 || targetNum > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number");

int guess;

while (true)
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == targetNum)
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
    else if (guess < targetNum)
    {
        Console.WriteLine($"{guess} is too low.");
    }
    else if (guess > targetNum)
    {
        Console.WriteLine($"{guess} is too high.");
    }
}