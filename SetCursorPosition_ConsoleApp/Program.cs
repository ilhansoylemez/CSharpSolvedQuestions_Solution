Random random = new Random();
int num;
int num1;

for (int i = 0; i < 100; i++)
{
    num = random.Next(1,19);
    num1 = random.Next(1,20);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.SetCursorPosition(num, num1);
    Console.WriteLine("*");
}