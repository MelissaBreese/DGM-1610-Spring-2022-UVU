using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Some of my all time favorite movies!:");
      string[] movies = {"Iron-Man", "Thor", "Harry Potter", "Avatar", "Venum"};
      foreach (string i in movies) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}