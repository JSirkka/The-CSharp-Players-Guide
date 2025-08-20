Console.WriteLine("How many eggs were gathered today?");
int totalEggs = Convert.ToInt32(Console.ReadLine());

int sisters = 4;
int eggsPerSister = totalEggs / sisters;
int eggsToDuckbear = totalEggs % sisters;

Console.WriteLine($"The sisters get {eggsPerSister} each and the duckbear gets {eggsToDuckbear}");

/*
3, 6 and 7 are examples when the duckbear gets more than the sisters.
When the amount of eggs are less than total sisters, then the duckbear gets all of the eggs.
If the egg count is 6 the sisters get 1 egg each and the duckbear 2.
If the egg count is 7 the sisters get 1 egg each and the duckbear 3.
The duckbear can either get 0, 1, 2 or 3 eggs.

1,2,3,6,7,11 are all the cases where the duckbear gets more eggs than each of the sisters.
 
 */