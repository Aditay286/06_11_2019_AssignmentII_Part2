using System;

namespace _06_11_2019_Assignment2
{
 class Q19
{
  public static void Run()
  {
    string input;int size,temp=0;
    Console.WriteLine("Enter the size of an array");
    input=Console.ReadLine();
    if(Int32.TryParse(input,out size))
    {
    int[] numbers=new int[size];
           Console.WriteLine("Enter the no");
     numbers[0]=Int32.Parse(Console.ReadLine());
     temp=numbers[0];
    for(int index=1;index<size;index++)
    {
        Console.WriteLine("Enter the no");
        numbers[index]=Int32.Parse(Console.ReadLine());
        if(temp>numbers[index])
         temp=numbers[index];
    }
    Console.WriteLine("Smallest no in an array is {0}",temp);
    }
    else
    {
        Console.WriteLine("Invald input");
    }


  }



}





}