

int askForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int askForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int num = askForNumber(text);
        
        if(num > min && num < max)
        {
            return num;
        }
    }
}


Console.WriteLine(askForNumberInRange("Give me number between 1 and 10", 1, 10));