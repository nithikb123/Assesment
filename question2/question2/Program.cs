using question2;

Console.WriteLine("Name:");
string Name1 = Console.ReadLine();
Console.WriteLine("Model:");
string Model1 = Console.ReadLine();
Console.WriteLine("Price:");
int Price1 = int.Parse(Console.ReadLine());
Console.WriteLine("Company:");
string Company1 = Console.ReadLine();

var mobile1 = new Mobile();
var mobile2 = new Mobile();

mobile1.GetData(Name1, Model1, Price1, Company1);
mobile2.GetData(Name1, Model1, Price1);

Console.WriteLine(mobile1.Name);
Console.WriteLine(mobile2.Company);