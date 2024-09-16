using System;
class reverse
{
    static void recursive(string app, int length)
    {
        if (length < 0)
        {
            return;
        }


        Console.Write(app[length]);
        recursive(app, length - 1);



    }
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int count = word.Length - 1;
        recursive(word, count);
    }
}