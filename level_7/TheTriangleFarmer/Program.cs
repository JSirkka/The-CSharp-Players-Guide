Console.WriteLine("Input triangle base");
float triangleBase = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Input triangle height");
float triangleHeight = Convert.ToSingle(Console.ReadLine());

float triangleArea = (triangleBase * triangleHeight) / 2;

Console.WriteLine($"The area of a triangle with base={triangleBase} and height={triangleHeight} is {triangleArea}");
