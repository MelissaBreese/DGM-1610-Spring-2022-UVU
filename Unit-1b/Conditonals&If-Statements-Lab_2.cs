using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome To Math Class lol TT");
		DoMath(185, 340);
		DoMath(214, 110);
		DoMath(85, 40);
		Compare(18, 45);
		Compare(52, 20);
	}
	
	public void DoMath(int value, int value2) {
		var number = value + value2;	
		Console.WriteLine(number);
	}
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the second is greater.");
		} else { 
			Console.WriteLine("False, the first is greater.");
		}
	}
}