using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Greet("Alice");
      
    }
    
    static void Greet(string name) {
    	Console.WriteLine("Hello, " + name + "!");
    }
  }
}