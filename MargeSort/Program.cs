// Сортировка слиянием
using System;

class Program
{
    //метод для слияния массивов
    static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
    {
        var left = lowIndex;
        var right = middleIndex + 1;
        var tempArray = new int[highIndex - lowIndex + 1];
        var index = 0;

        while ((left <= middleIndex) && (right <= highIndex))
        {
            if (array[left] < array[right])
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= middleIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = right; i <= highIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = 0; i < tempArray.Length; i++)
        {
            array[lowIndex + i] = tempArray[i];
        }
    }

    //сортировка слиянием
    static int[] MergeSort(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middleIndex);
            MergeSort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }

        return array;
    }

    static int[] MergeSort(int[] array)
    {
        return MergeSort(array, 0, array.Length - 1);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Сортировка слиянием");
        Console.Write("Введите элементы массива: ");
        var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        var array = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            array[i] = Convert.ToInt32(s[i]);
        }

        Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", MergeSort(array)));

        Console.ReadLine();
    }
}

/*
static int[] temporaryArray;

static void Merge(int[] array, int start, int middle, int end)
{
    var leftPtr = start;
    var rightPtr = middle + 1;
    var length = end - start + 1;
    for (int i = 0; i < length; i++)
    {
        if (rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
        {
            temporaryArray[i] = array[leftPtr];
            leftPtr++;
        }
        else
        {
            temporaryArray[i] = array[rightPtr];
            rightPtr++;
        }
    }
    for (int i = 0; i < length; i++)
        array[i + start] = temporaryArray[i];
}

static void MergeSort(int[] array, int start, int end)
{
    if (start == end) return;
    var middle = (start + end) / 2;
    MergeSort(array, start, middle);
    MergeSort(array, middle + 1, end);
    Merge(array, start, middle, end);

}

static void MergeSort(int[] array)
{
    temporaryArray = new int[array.Length];
    MergeSort(array, 0, array.Length - 1);
}

public static void Main()
{
    int[] array = { 3, 2, 5, 7, 8, 1, 9 };
    MergeSort(array);
    foreach (var e in array)
        Console.WriteLine(e);
    Console.ReadKey();
}
*/