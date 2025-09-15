

void recursiveCount(int n)
{
    if (n == 0) return;
    
    Console.WriteLine(n);
    recursiveCount(n - 1);
}


recursiveCount(10);