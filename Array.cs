using System;

public class Array : IOutput
{
    private int[] elements;

    public Array(int[] arr)
    {
        elements = arr;
    }

    public void Show()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Додаткова інформація: " + info);
    }
}
