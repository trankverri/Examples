// See https://aka.ms/new-console-template for more information
// Console.Beep();
// Console.WriteLine("Hello, Masha!");
// Console.WriteLine("Нажмите любую клавишу, а затем Enter");
// int key1 = Console.Read();
// Console.WriteLine($"Код нажатой клавиши: {key1}");
// Console.WriteLine("Символьное представление: " + Convert.ToChar(key1));

// Console.WriteLine("Нажмите любую клавишу:");
// var key2 = Console.ReadKey();
// Console.WriteLine(key2.Key);
// Console.WriteLine(key2.KeyChar);

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// факториал числа
int FactorialNum(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int m)
{
    if (m == 1) return 1;
    else return m * FactorialRec(m - 1);
}
// a в степени n
int PowerRec(int a, int n)
{ // return n==0? 1 :PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRec2(int a, int n)
{ // return n==0? 1 :PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRec2(a * a, n / 2);
    else return PowerRec2(a, n - 1) * a;
}

int n = 1;
void FindWords(string alfabet, char[] world, int length = 0)
{
    if (length == world.Length)
    {
        Console.WriteLine($"{n++} {new String(world)}"); return;

    }
    for (int i = 0; i < alfabet.Length; i++)
    {
        world[length] = alfabet[i];
        FindWords(alfabet, world, length + 1);
    }
}

//Console.WriteLine(SumRec(10));
// Console.WriteLine(FactorialNum(10));
// Console.WriteLine(FactorialRec(10));
// Console.WriteLine(PowerRec(2,10));
// Console.WriteLine(PowerRec2(2,10));

// FindWords("аисв", new char[2]);

string path = "C:/Repositories/Examples/Ex008_C#";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
// string path2 ="C:/Repositories/Examples/ex005_hello";
// CatalogInfo(path2);

//Собираем пирамидки 3 башни
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

//Towers();

//бинарное дерево. обход структуры
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int rigth = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
    }
}
InOrderTraversal();