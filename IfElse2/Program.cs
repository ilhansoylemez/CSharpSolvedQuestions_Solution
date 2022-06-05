Console.WriteLine("Enter gender information. M/W ");
char value = Convert.ToChar(Console.ReadLine());
if (value.Equals('w') || value.Equals('W'))
{
    Console.WriteLine("Woman");
}
else if (value == 'm' || value=='M')
{
    Console.WriteLine("Male");
}
else
{
    Console.WriteLine("Enter a valid value");
}