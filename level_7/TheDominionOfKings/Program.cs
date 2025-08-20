Console.WriteLine("Amount of provinces:");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Amount of dutchies:");
int dutchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Amount of estates:");
int estates = Convert.ToInt32(Console.ReadLine());

int totalScore = (provinces * 6) + (dutchies * 3) + estates;

Console.WriteLine($"Total score is {totalScore}");