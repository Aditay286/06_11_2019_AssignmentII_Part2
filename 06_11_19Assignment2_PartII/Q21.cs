using System;
namespace _06_11_2019_Assignment2
{
 class Q21
{
  public static void Run()
  {
    string input;int size,count=0;
    Console.WriteLine("Enter the size of an array");
    input=Console.ReadLine();
    if(Int32.TryParse(input,out size))
    {
    int[] numbers=new int[size];
    for(int index=0;index<size;index++)
    {
           Console.WriteLine("Enter the no");
        numbers[index]=Int32.Parse(Console.ReadLine());
        if(numbers[index]%2==0)
         ++count;
    }
    Console.WriteLine("Even nos in an array is {0}",count);
    }
    else
    {
        Console.WriteLine("Invald input");
    }
    }
  }
}