
int length = 5;

int[] original_arr = new int[length];

for (int i = 0; i < original_arr.Length; i++)
{
    Console.WriteLine($"Please enter number {i + 1} of {original_arr.Length}: ");
    original_arr[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copy_arr = new int[length];

for (int i = 0; i < copy_arr.Length; i++)
{
    copy_arr[i] = original_arr[i];
}


Console.WriteLine($"{"Index",8}|{"Orginal",8}|{"Copy",8}");
for (int i = 0; i < copy_arr.Length; i++)
{
    Console.WriteLine($"{i,8}|{original_arr[i],8}|{copy_arr[i],8}");
}
