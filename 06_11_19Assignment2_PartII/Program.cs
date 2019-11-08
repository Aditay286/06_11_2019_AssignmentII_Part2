using System;

namespace _06_11_2019_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
     string input;int no,choice;
    do{
        Console.WriteLine("_06_11_2019_Assignment2 part-II");
        Console.WriteLine("Enter the Question no you want to run or for all at once enter 0");
        input=Console.ReadLine();    
        if(Int32.TryParse(input,out no))
        {
        switch(no)
        {
            case 0:
            Console.WriteLine("Question-19");
            Q19.Run();
            Console.WriteLine("Question-20");       
            Q20.Run();
                   Console.WriteLine("Question-21");
            Q21.Run();
                   Console.WriteLine("Question-22");
            Q22.Run();
                   Console.WriteLine("Question-23");
            Q23.Run();
                   Console.WriteLine("Question-24");
            Q24.Run();
                   Console.WriteLine("Question-25");
            Q25.Run();
                   Console.WriteLine("Question-26");
            Q26.Run();
                   Console.WriteLine("Question-27");
            Q27.Run();
                   Console.WriteLine("Question-28");
            Q28.Run();
                   Console.WriteLine("Question-29");
            Q29.Run();
                   Console.WriteLine("Question-30");
            Q30.Run();
                   Console.WriteLine("Question-31");
            Q31.Run();
            break;
        case 19:
            Q19.Run();
            break;
        case 20:
            Q20.Run();
            break;
        case 21:
            Q21.Run();
            break;
        case 22:
            Q22.Run();
            break;
        case 23:
            Q23.Run();
            break;
        case 24:
            Q24.Run();
            break;
        case 25:
            Q25.Run();
            break;
        case 26:
            Q26.Run();
            break;
        case 27:
            Q27.Run();
            break;
        case 28:
            Q28.Run();
            break;
        case 29:
            Q29.Run();
            break;
        case 30:
            Q30.Run();
            break;
        case 31:
            Q31.Run();
            break;
        default:
            Console.WriteLine("Question no {0} does not exist",no);
        break;
        }
      }
           else
        {
            Console.WriteLine("Not an Integer Value");
        }
       Console.WriteLine("Do you want to run another program 1.yes 2.no");
        string input2=Console.ReadLine(); 
       while(!(Int32.TryParse(input2,out choice)))
       {
        Console.WriteLine("Renter the choice");   
         input2=Console.ReadLine();                
       }
      }while(choice==1);
     }   
  }
}
