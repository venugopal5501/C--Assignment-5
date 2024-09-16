using System;
class factorial
{
    static int fact(int x)

    {
        if (x <= 1)
        {
            return 1;
        }
        else
        {
            return x * fact(x - 1);
        }
    }
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int res=fact(a);
        Console.WriteLine(" " + res);
    }
}