int[] ints = new int[5];
int gecici = 1;

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < ints.Length; i++)
{
    for (int j = 0; j < ints.Length; j++) 
    {
        if (ints[j] >= ints[i])
        {
            gecici = ints[i];
            ints[i] = ints[j];
            ints[j] = gecici;
         }
    }
}
foreach (var item in ints)
{
    Console.WriteLine(item);
}


