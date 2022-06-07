Char gender;
bool militaryStatus;
int age;

Console.Write("Gender M/F: ");
gender = Convert.ToChar(Console.ReadLine());
Console.Write("MilitaryStatus: True/False: ");
militaryStatus = Convert.ToBoolean(Console.ReadLine());
Console.Write("Age: ");
age = Convert.ToInt32(Console.ReadLine());

if (age > 20 && gender == 'M' && militaryStatus==true) 
{
    Console.WriteLine("A job application has been made.");
}
else
{
    Console.WriteLine("Conditions are not favorable.");
}