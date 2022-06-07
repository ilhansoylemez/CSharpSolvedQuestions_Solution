int num, k = 0; ;
List<int> list = new List<int>();
for (int i = 0; i < 10; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 99 && num<999)
    {
      list.Add(num);
    }
}
foreach (var item in list)
{
    k++;
    Console.WriteLine("{0}.Digit Number: {1}",k,item);
}