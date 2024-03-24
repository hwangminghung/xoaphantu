using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Mang ban dau:");
        PrintArray(array);

        int elementToRemove = 3;

        array = RemoveElementFromArray(array, elementToRemove);

        Console.WriteLine($"Mang sau khi xoa phan tu {elementToRemove}:");
        PrintArray(array);
    }

    static int[] RemoveElementFromArray(int[] array, int element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            return newArray;
        }
        else
        {
            return array;
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}