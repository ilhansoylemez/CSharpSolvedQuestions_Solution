double n1, n2, n3, n4, n5, n6;
Console.Write("Enter a number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a number: ");
n2 = Convert.ToDouble(Console.ReadLine());

n2 += n1;
Console.WriteLine("Sum of two numbers: {0}", n2);

Console.Write("Enter a number: ");
n3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a number: ");
n4 = Convert.ToDouble(Console.ReadLine());

n4 *= n3;
Console.WriteLine("Multiplication of two numbers: {0}", n4);

Console.Write("Enter a number: ");
n5 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a number: ");
n6 = Convert.ToDouble(Console.ReadLine());

n5 %= n6;
Console.WriteLine("Modulus number: {0}", n5);