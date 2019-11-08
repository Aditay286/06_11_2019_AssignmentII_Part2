using System;
namespace _06_11_2019_Assignment2
{ 
  class Q23
  {
    public static void Run()
    {
        int number,palindrome=0,number2;string input;
        Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out number))
        {
            number2=number;
            while(number>0)
            {
               palindrome=palindrome*10+(number%10);
               number/=10;
            }
            if(number2==palindrome)
             Console.WriteLine("Number is  palindrome");
             else
            Console.WriteLine("Number is  not palindrome");     
        }
        else
        Console.WriteLine("Invalid Input");
     }
  }
}