using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <= 100; i = i + 5)
      {
        Console.WriteLine(i);
        // the difference here with if it's regualr vs by twos, fours, etc is the i = i + 5 part with the number after the + to be specific//;
        
      }    
    }
  }
}