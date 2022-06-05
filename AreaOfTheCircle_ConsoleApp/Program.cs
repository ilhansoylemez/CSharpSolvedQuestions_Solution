double r, area, perimeter;
Console.Write("Enter The Radius Of The Circle: ");
r = Convert.ToDouble(Console.ReadLine());
area = Math.PI * r * r;
perimeter = 2 * Math.PI * r;
Console.WriteLine("Area Of ​​The Circle: {0:F2}", area);
Console.WriteLine("Area Of The Perimeter: {0:F2}", perimeter);
Console.ReadLine();