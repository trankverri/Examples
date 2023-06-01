// See https://aka.ms/new-console-template for more information
Console.Beep();
Console.WriteLine("Hello, Masha!");
Console.WriteLine("Нажмите любую клавишу, а затем Enter");
int key1 = Console.Read();
Console.WriteLine($"Код нажатой клавиши: {key1}");
Console.WriteLine("Символьное представление: " + Convert.ToChar(key1));

Console.WriteLine("Нажмите любую клавишу:");
var key2 = Console.ReadKey();
Console.WriteLine(key2.Key);
Console.WriteLine(key2.KeyChar);

