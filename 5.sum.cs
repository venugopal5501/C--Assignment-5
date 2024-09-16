using System;
class sum
{
    static int add(int num)
    {
        int add = 0;
        while (num > 0)
        {
            int last = num % 10;
            add = add + last;
            num = num / 10;
        }
        return add;

    }
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int res = add(a);
        Console.Write(res);
    }
}