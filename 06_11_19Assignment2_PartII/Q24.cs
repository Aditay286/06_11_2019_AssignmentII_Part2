using System;
namespace _06_11_2019_Assignment2
{ 
  class Q24
  {
    public static void Run()
    {
       int[] array1,array2,merge;int size1,size2,index;string input1,input2;
       Console.WriteLine("Enter the size of first array");
       input1=Console.ReadLine();
       Console.WriteLine("Enter the size of second array");
       input2=Console.ReadLine();

       if(Int32.TryParse(input1,out size1)&&Int32.TryParse(input2,out size2))
       {
           array1=new int[size1];
           array2=new int[size2];
           merge=new int[size1+size2];
           
           Console.WriteLine("Enter the element of first array");
           for(index=0;index<size1;index++)
           {
               Console.WriteLine("Enter the no");
               array1[index]=Int32.Parse(Console.ReadLine());
           }
                      Console.WriteLine("Enter the element of second array");
                  for(index=0;index<size2;index++)
           {
               Console.WriteLine("Enter the no");
               array2[index]=Int32.Parse(Console.ReadLine());
           }
           for(index=0;index<size1+size2;index++)
           {
               if(index<size1)
                merge[index]=array1[index];
                else
                merge[index]=array2[index-size1];
           }
           Sort(merge);
           Console.WriteLine("first array");
           Console.WriteLine(string.Join(",",array1));
           Console.WriteLine("second array");
           Console.WriteLine(string.Join(",",array2));
           Console.WriteLine("merged array");  
           Console.WriteLine(string.Join(",",merge)); 
       }
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
  }
}