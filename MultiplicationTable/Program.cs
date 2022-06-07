

for (int i = 0; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine("{0} * {1} = {2}", i,j, i*j);
        if (j == 10)
            Console.WriteLine("-------------------");
    }
}
