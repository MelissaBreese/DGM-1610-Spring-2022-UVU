using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Outer loop
      for (int i = 1; i <= 4; ++i) 
      {
        Console.WriteLine("Music: "+  i);  
          
        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
          Console.WriteLine("Artist: "+  j);  
        }
      }    
    }
  }
}