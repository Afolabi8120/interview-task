using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int userInput;
      
      Console.WriteLine("Input a value");
      userInput = Convert.ToInt32(Console.ReadLine());
      
      if(userInput % 2 == 0) {
      	Console.WriteLine("Even");
      }else {
      	Console.WriteLine("Odd");
      }
    }
  }
}