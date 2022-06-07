int[] ints = new int[5];
int bigNumber=1;

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
    if(ints[i] > bigNumber)
    {
        bigNumber = ints[i];
    }
}
Console.WriteLine(bigNumber);