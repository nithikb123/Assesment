using Experionproject;

var p1 = new Employees()
{
    Name = "Anoop",
    Department = "A",
    Designation = "Trainee",
   
};
var p2 = new Employees()
{
    Name = "Namitha",
    Department = "B",
    Designation = "Manager",

};
Console.WriteLine(p1.Name);
Console.WriteLine(p1.Department);
Console.WriteLine(p1.Designation);
Console.WriteLine(p1.Salary);

Console.WriteLine(p2.Name);
Console.WriteLine(p2.Department);
Console.WriteLine(p2.Designation);
Console.WriteLine(p2.Salary);