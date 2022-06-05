int number = 10;
double numbertwo = 10.5;
char character = 'A';
string word = "Car";
bool value = true; // true or false 

Console.WriteLine("Number={0}, NumberTwo={1}, Character={2}, Word={3}, Bool={4}",number,numbertwo,character,word,value);

/* Example */
Console.Write("Number 1:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 3:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 4:");
int num4 = Convert.ToInt32(Console.ReadLine());
float sum = num + num2 + num3 + num4;
float division = sum / 4; 
Console.WriteLine(division);
