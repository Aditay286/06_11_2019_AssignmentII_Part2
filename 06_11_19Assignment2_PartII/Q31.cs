using System;
namespace _06_11_2019_Assignment2
{
    class Q31
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
                Insertion_Sort(array);
                Console.WriteLine("array after sorting using Insertion Sort");
                Print(array);   
            }
            else
            Console.WriteLine("Not an integer value");
        }
       public static void Insertion_Sort(int[] array)  //ascending order
       {
          int index,index2,key;
          for(index=1;index<array.Length;index++)
          {
             key=array[index];
             index2=index-1;

             while(index2>=0&&array[index2]>key)
             {
                 array[index2+1]=array[index2];
                 index2--;
             }
             array[index2+1]=key;
          }
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