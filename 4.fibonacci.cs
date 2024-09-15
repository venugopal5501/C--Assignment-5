using System;
class fibonacci
{
    static void yes(int num)
    {
        Console.Write("0 1 ");
        int a = 0, b = 1;
        for (int i = 2; i < num; i++)
        {
            int next = a + b;
            a = b;
            b = next;
            Console.Write(next +" ");
        }
        

    }
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        yes(a);


    }
}