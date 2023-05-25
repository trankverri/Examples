// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string user = "Bob";
// Console.WriteLine($"Приет - {user}");

// Console.Write("Hello, input ...");
// // string num = Console.ReadLine();
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Приет - {num + 100}");

// Console.Write("Hello, input ...");
// // string num = Console.ReadLine();
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Приет - {num * num}");

// Console.Write($"Приет - {num / 10}");
// Console.Write($"Приет - {num %  4}");

// if (num > 10)
// {
//    Console.Write($"> 10");
//    }
// else
// {
//     Console.Write($"< 10");
// }

// Console.Write("Hello, input num1 ...");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Hello, input num2 ...");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ((num2 * num2) == num1)
// {
//    Console.WriteLine("kvadrat");
//    }
// else
// {
//     Console.WriteLine("ne kvadrat");
// }


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string[] mas = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

// if (num < 8 && num > 0)
// {
//     Console.WriteLine($"День недели: {mas[num - 1]}");
// }
// else
// {
//     Console.WriteLine("Нет такого дня недели");
// }


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num);
// int res = num % 10;
// Console.Write(res);
// Random dice = new Random();

// int roll1 = dice.Next(1, 10);
// int roll2 = dice.Next(1, 10);
// int roll3 = dice.Next(1, 10);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }
// else 
// {
//     Console.WriteLine("Sorry, you lose.");
// }