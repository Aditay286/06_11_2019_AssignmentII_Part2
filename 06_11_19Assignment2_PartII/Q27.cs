using System;
namespace _06_11_2019_Assignment2
{ 
  class Q27
  {
    public static void Run()
    {
        int row,column;
        int m_Row,n_Column;
        int[,] array,transpose_Array;
        Console.WriteLine("Enter the no of row in array");
        m_Row=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the no of column in array");
        n_Column=Int32.Parse(Console.ReadLine());
        array=new int[m_Row,n_Column];
        transpose_Array=new int[n_Column,m_Row];
        Console.WriteLine("Enter the element of an array");
        Input(array,m_Row,n_Column);
    for(row=0;row<n_Column;row++)
    {
        for(column=0;column<m_Row;column++)
        {
        transpose_Array[row,column]=array[column,row];
        }
    }
    Console.WriteLine("Elements of  array");
    Print(array,m_Row,n_Column);
    Console.WriteLine("Elements of transpose array");   
    Print(transpose_Array,n_Column,m_Row);
    }
    static void Input(int[,] array,int m_Ro,int n_Col)
    {
        int row,column;
    for(row=0;row<m_Ro;row++)
      {
          for(column=0;column<n_Col;column++)
          {
              Console.WriteLine("Enter the no");
              array[row,column]=Int32.Parse(Console.ReadLine());
          }
      }
    }
   static void Print(int[,] a,int m_Ro,int n_Col)
   {
       int row=0,column=0;
       for(row=0;row<m_Ro;row++)
       {
           for(column=0;column<n_Col;column++)
           {
               Console.Write("{0} ",a[row,column]);
           }
           Console.WriteLine();
       }
   }
  }
}