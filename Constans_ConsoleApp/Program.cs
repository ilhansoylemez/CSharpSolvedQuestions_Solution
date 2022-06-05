const int fullTicket = 10;
const int studentTicket = 7;

int sts, fts, result;
Console.Write("Full Ticket: ");
fts = Convert.ToInt32(Console.ReadLine());
Console.Write("Student Ticket: ");
sts = Convert.ToInt32(Console.ReadLine());
result = (fts * fullTicket) + (sts * studentTicket);
Console.WriteLine("Amount to be paid:{0}",result);
