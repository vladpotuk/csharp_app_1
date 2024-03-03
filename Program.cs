using System;

class Program
{
    static void Main(string[] args)
    {
        

        
        int[] arr = { 1, 2, 3, 4, 5 };

        
        Array array = new Array(arr);

        
        array.Show();
        array.Show("Це інформаційне повідомлення.");
    }
}

