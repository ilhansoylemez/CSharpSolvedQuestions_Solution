double num, num2, num3, num4;
Console.Write("Enter Number: ");
num = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Number: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Number: ");
num3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Number: ");
num4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("{0} + {1} + {2} + {3} / 4 = {4}", num, num2, num3, num4, (num + num2 + num3 + num4) / 4);