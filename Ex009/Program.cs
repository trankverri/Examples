// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {25, 33, 34, 12, 10, 450, 11, 1008, 14};


// // int b1 = 33;
// // int c1 = 34;
// // int a2 = 12;
// // int b2 = 10;
// // int c2 = 450;
// // int a3 = 11;
// // int b3 = 1008;
// // int c3 = 14;

// // // int max1 = Max(a1, b1, c1);
// // // int max2 = Max(a2, b2, c2);
// // // int max3 = Max(a3, b3, c3);
// // int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);

// int[] massiv = { 1, 20, 3, 4, 50, 66, 7, 3 };
// int n = massiv.Length;
// int find = 3;

// int index = 0;

// while (index < n)
// {
//     if (massiv[index] == find)
//     {
//         break;
//     }
//     index++;
// }

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
