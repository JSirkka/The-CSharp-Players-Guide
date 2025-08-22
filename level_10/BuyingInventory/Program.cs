Console.WriteLine(
    "The following items are available: \n" +
    "1 - Rope\n" +
    "2 - Torches\n" +
    "3 - Climbing Equipment\n" +
    "4 - Clean Water\n" +
    "5 - Machete\n" +
    "6 - Canoe\n" +
    "7 - Food Supplies\n"
    );

Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

string response = choice switch
{
    1 => "Rope cost 10 gold",
    2 => "Torches cost 15 gold",
    3 => "Climbing Equipment cost 25 gold",
    4 => "Clean Water cost 1 gold",
    5 => "Machete cost 20 gold",
    6 => "Canoe cost 200 gold",
    7 => "Food Suplies cost 1 gold",
    _ => $"Unknown choice: {choice}"
};

Console.WriteLine(response);