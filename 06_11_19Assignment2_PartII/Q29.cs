using System;
namespace _06_11_2019_Assignment2
{
    class Q29
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
                Bubble_Sort(array);
                Console.WriteLine("array after sorting using Bubble Sort");
                Print(array);   
            }
            else
            Console.WriteLine("Not an integer value");
        }
        public static void Bubble_Sort(int[] array)      //for ascending order
        {
            int index1,index2,temp;;
            for(index1=0;index1<array.Length-1;index1++)
            {
                for(index2=0;index2<array.Length-index1-1;index2++)
                {
                    if(array[index2]>array[index2+1])
                    {
                        temp=array[index2];
                        array[index2]=array[index2+1];
                        array[index2+1]=temp;
                    }
                }
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