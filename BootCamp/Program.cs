// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Input numb elements");
int n=int.Parse(Console.ReadLine()!);
int[] array=new int[n];
for (int i = 0; i < array.Length; i++){
    array[i]-new Random().Next(-20,20);}
Console.WriteLine($"Начальный массии: [{string.join(", ",array)}]");
