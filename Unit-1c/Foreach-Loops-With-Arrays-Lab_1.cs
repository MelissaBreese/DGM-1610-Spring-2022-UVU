using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Some of my all time favorite animes!");
      string[] animes = {"Fairy Tail", "My Hero Academeia", "Beast Tamer", "One Piece", "Rising Of The Shield Hero"};
      foreach (string i in animes) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}