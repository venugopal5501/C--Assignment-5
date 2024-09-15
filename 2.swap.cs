using System;
class swap{
    static void swaps(int a, int b){
        int temp=a;
        a=b;
        b=temp;
       Console.WriteLine(" "+a);
       Console.WriteLine(" "+b);

    }
    public static void Main(string []args){
        int x=Convert.ToInt32(Console.ReadLine());
        int y=Convert.ToInt32(Console.ReadLine());
        swap.swaps(x,y);
    }
}