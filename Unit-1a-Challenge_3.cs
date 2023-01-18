using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 15;
      Console.WriteLine(!(x > 3 && x < 10)); // returns False because ! (not) is used to reverse the result. Or in otherwords, it's the rules of opposite day when ! is used in this type of function.
     }
  }
}