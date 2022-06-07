int num, num2, result=0;

Console.WriteLine("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter a number: ");
num2= Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num2; i++)
{
    result = result + num;
}

Console.WriteLine(result);