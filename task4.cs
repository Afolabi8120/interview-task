using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = {2, 4, 6, 8, 10};
      int counter = 0;
      
      foreach(int number in numbers) {
      	counter = counter + number;
      }
      
      Console.WriteLine(counter);
      
    }
  }
}