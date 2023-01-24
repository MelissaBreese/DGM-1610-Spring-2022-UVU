using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome To Math Class lol TT");
		DoMath(24, 85);
		DoMath(72, 48);
		DoMath(52, 67);
		Compare(35, 12);
		Compare(87, 95);
	}
	
	public void DoMath(int value, int value2) {
		var number = value + value2;	
		Console.WriteLine(number);
	}
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first is greater.");
		} else { 
			Console.WriteLine("False, the second is greater.");
		}
	}
}