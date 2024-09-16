using System;
class odd{
    static  void odds(int x, int y){
        if(x>y){
            return ;
        }
        if(x%2==0){
            Console.Write(x+ " ");
        }
        
        odds(x+1,y);

    }
    public static void Main(string []args){
        int start=Convert.ToInt32(Console.ReadLine());
        int end=Convert.ToInt32(Console.ReadLine());
        odds(start,end);


    }
}