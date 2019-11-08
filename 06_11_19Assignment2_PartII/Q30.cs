using System;
namespace _06_11_2019_Assignment2
{
    class Q30
    {
        public static void Run()
        {
          int[] array;string input;int size,index;

            Console.WriteLine("Enter the size of the array"); 
            input=Console.ReadLine();

            if(Int32.TryParse(input,out size))
            {
                array=new int[size];
             for(index=0;index<size;index++)
             {
              Console.WriteLine("Enter the no");
               array[index]=Int32.Parse(Console.ReadLine());
             }
                Console.WriteLine("array before sorting");
                Print(array);
                Selection_Sort(array);
                Console.WriteLine("array after sorting using Selection Sort");
                Print(array);   
            }
            else
            Console.WriteLine("Not an integer value");
       }
       public static void Selection_Sort(int[] array)  //ascending order
       {
           int index,min_Pos,temp;
           for(index=0;index<array.Length-1;index++)
           {
               min_Pos=Find_Min_Pos(array,index,array.Length);
               if(index!=min_Pos)
               {
                   temp=array[index];
                   array[index]=array[min_Pos];
                   array[min_Pos]=temp;
               }
           }
       }
       public static int Find_Min_Pos(int[] array,int start,int end)
       {
           int index,min_Pos=start;
           for(index=start+1;index<end;index++)
           {
               if(array[index]<array[min_Pos])
               {
                   min_Pos=index;
               }
           }
           return min_Pos;
       }
      public  static void Print(int[] array)
      {
       int index=0;
       for(index=0;index<array.Length;index++)
       {
           Console.WriteLine(array[index]+" ");
       }
     }
   }
}