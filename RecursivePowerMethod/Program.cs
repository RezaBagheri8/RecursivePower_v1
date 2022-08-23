using RecursivePowerMethod;

Console.WriteLine("Please enter number : ");
var Inputnumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter power : ");
var Inputpower = int.Parse(Console.ReadLine());

var power = new Power();
var result = power.Calculate(Inputnumber, Inputpower);

Console.WriteLine($"result is : {result}");

