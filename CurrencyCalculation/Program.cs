double tl, euro, dolar, euroCurrency, dolarCurrency;
Console.WriteLine("How Much Money Do You Have?");
tl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How Much Euro?");
euroCurrency = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How Much Dolar?");
dolarCurrency = Convert.ToDouble(Console.ReadLine());

euro = tl / euroCurrency;
dolar = tl / dolarCurrency;

Console.WriteLine("You Have {0} Euros", euro);
Console.WriteLine("You Have {0} Dollars", dolar);
