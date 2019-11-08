using System;
namespace _06_11_2019_Assignment2
{ 
  class Q25
  {
    public static void Run()
    {
        int row,column;
      int[,] array1=new int[3,3];
      int[,] array2=new int[3,3];
      int[,] added_Array=new int[3,3];

    Console.WriteLine("Enter the element of first array");
    Input(array1);
    Console.WriteLine("Enter the element of second array");     
    Input(array2);
    for(row=0;row<3;row++)
    {
        for(column=0;column<3;column++)
        {
            added_Array[row,column]=array1[row,column]+array2[row,column];
        }
    }
    Console.WriteLine("Elements of first array");
    Print(array1);
    Console.WriteLine("Elements of second array");   
    Print(array2);
    Console.WriteLine("Elements of added array");   
    Print(added_Array);
    }
    static void Input(int[,] array)
    {
        int row,column;
              for(row=0;row<3;row++)
      {
          for(column=0;column<3;column++)
          {
              Console.WriteLine("Enter the no");
              array[row,column]=Int32.Parse(Console.ReadLine());
          }
      }
    }
   static void Print(int[,] a)
   {
       int row=0,column=0;
       for(row=0;row<3;row++)
       {
           for(column=0;column<3;column++)
           {
               Console.Write("{0} ",a[row,column]);
           }
           Console.WriteLine();
       }
   }
  }
}