

/*
 * Prototype Design Pattern nesne oluşturma maliyetli ve çok kaynak gerektiren bir iş olduğunda, yeni bir nesne yaratmak yerine, benzer bir nesneyi kullanarak işlemlerin gerçekleştirilmesini sağlar. Bu tasarım deseni, bir nesnenin kopyasını alarak yeni bir nesne oluşturur. Bu desen, nesne oluşturma maliyetini azaltır ve performansı artırır.
 * */

using Prototype.Sample_1;
using Prototype.Sample_2;


///////////////////////////SAMPLE 1///////////////////////////
Employee employee = new Employee();
employee.LoadData();
Employee employee1 = (Employee)employee.Clone();
Employee employee2 = (Employee)employee.Clone();

List<string> list = employee2.GetEmployeeList();
list.Add("Hasan");

Console.WriteLine("Employees: " + employee.GetEmployeeList());
foreach (var item in employee.GetEmployeeList())
{
    Console.WriteLine(item);
}
Console.WriteLine(new string('*', 50));
Console.WriteLine("Employees 1: " + employee1.GetEmployeeList());
foreach (var item in employee1.GetEmployeeList())
{
    Console.WriteLine(item);
}

Console.WriteLine(new string('*', 50));

Console.WriteLine("Employees 2 : " + employee2.GetEmployeeList());
foreach (var item in employee2.GetEmployeeList())
{
    Console.WriteLine(item);
}
///////////////////////////SAMPLE 1///////////////////////////





///////////////////////////SAMPLE 2///////////////////////////
Game g1 = new Game(1, "Game1", "Type1", true);
Game g2 = (Game)g1.Clone();
Game g3 = g1;

Console.WriteLine(  $"g1: {g1._GameName} - {g1._GameType}");
Console.WriteLine(  $"g2: {g2._GameName} - {g2._GameType}");
Console.WriteLine(  $"g2: {g3._GameName} - {g3._GameType}");
Console.WriteLine(new string('#', 50));

g1._GameName = "Game1 UPDATED";
g1._GameType = "Type1 UPDATED";


Console.WriteLine($"g1: {g1._GameName} - {g1._GameType}");
Console.WriteLine($"g2: {g2._GameName} - {g2._GameType}");
Console.WriteLine($"g2: {g3._GameName} - {g3._GameType}");
Console.WriteLine(new string('#', 50));

if (g1.Equals(g2))
{
    Console.WriteLine(  "Tipler Aynı");
}else Console.WriteLine("Tipler Farklı");