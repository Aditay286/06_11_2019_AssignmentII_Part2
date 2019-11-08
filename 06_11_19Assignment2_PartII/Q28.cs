using System;
namespace _06_11_2019_Assignment2
{
 class Q28
  {
      public static void Run()
      {
          int[] array;int size,index,max,min,mid=0,key;
          Console.WriteLine("Enter the size of an array");
          size=Int32.Parse(Console.ReadLine());
          array=new int[size];
          for(index=0;index<size;index++)
          {
              Console.WriteLine("Enter the no");
              array[index]=Int32.Parse(Console.ReadLine());
          }
          Console.WriteLine("Enter the number to be searched");
          key=Int32.Parse(Console.ReadLine());

          max=size-1;
          min=0;
          Sort(array);
          Print(array);
          Boolean flag=false;
          
          while(min<=max)
          {
              mid=(max+min)/2;
              if(key==array[mid])
              {
                  flag=true;
                break;
              }
              else if(key<array[mid])
              {
                 max=mid-1; 
              }
              else 
              {
                  min=mid+1;
              }
          }
          
          if(flag)
          {
              Console.WriteLine("number found at position {0}",mid);
          }
          else
          Console.WriteLine("number not found");
      }
      static void Sort(int[] array)
    {
        int index1,index2,temp;
       for(index1=0;index1<array.Length-1;index1++)
       {
           for(index2=index1+1;index2<array.Length;index2++)
           {
           if(array[index1]>array[index2])
           {
             temp=array[index1];
             array[index1]=array[index2];
             array[index2]=temp;
           }
       }
    }   
   }
   static void Print(int[] array)
   {
       int index=0;
       for(index=0;index<array.Length;index++)
       {
           Console.WriteLine(array[index]+" ");
       }
   }
 
  }
}