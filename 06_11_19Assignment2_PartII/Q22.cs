using System;

namespace _06_11_2019_Assignment2
{
 class Q22
 {
   public  static void Run()
    {
       string input,input2;int count=0,number,size,index;
       int[] array;
      Console.WriteLine("Enter the size of an array");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out size))
        {
            array=new int[size];
            for( index=0;index<size;index++)
            {
                Console.WriteLine("Enter the no");
                 array[index]=Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the no whose occurance is to find out");
            input2=Console.ReadLine();
            if(Int32.TryParse(input2,out number))
            {
              for(index=0;index<size;index++)
              {
                  if(array[index]==number)
                  count++;
              }
              Console.WriteLine("Occurance of {0} in an array is {1}",number,count);
            }
            else
            Console.WriteLine("Invalid input");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }




 }
}