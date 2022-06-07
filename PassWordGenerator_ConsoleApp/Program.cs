char[] chars = {'A','B','C','K','M','!','1','?'};

Random random = new Random();
int number;
for (int i = 0; i < chars.Length; i++)
{
  number = random.Next(chars.Length);
  Console.Write(chars[number] + " ");
}