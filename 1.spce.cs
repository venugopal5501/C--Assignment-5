using System;
class space{
    public static void Main(string []args){
        int count=0;
        Console.WriteLine("Enter Word : ");
        string word=Console.ReadLine();
        char[] arr=word.ToCharArray();
        for(int i=0;i<arr.Length;i++){
            if(arr[i]==' '){
                count++;
            }
        }
        Console.WriteLine(count);
        
    }
}