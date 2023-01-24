using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome To Math Class lol TT");
		DoMath(185, 340);
		DoMath(214, 110);
		DoMath(85, 40);
	}
	
	public void DoMath(int value, int value2) {
		var number = value + value2;	
		Console.WriteLine(number);
	}
}