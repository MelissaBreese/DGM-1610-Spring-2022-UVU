using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Some of my favorite Animes: ");
      string[] animes = {"Fairy Tail", "My Hero Academeia", "One Piece", "Rising Of The Shield Hero"};
      for (int i = 0; i < animes.Length; i++)
      {
      Console.WriteLine(animes[i]);
      }
    }
  }
}