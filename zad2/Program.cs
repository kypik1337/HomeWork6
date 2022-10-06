Console.WriteLine("Add number K1");
var K1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add number K2");
var K2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add number B1");
var B1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add number B2");
var B2 = Convert.ToDouble(Console.ReadLine());

var x = -(B1 - B2) / (K1 - K2);
var y = K1 * x + B1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"{x}, {y}");