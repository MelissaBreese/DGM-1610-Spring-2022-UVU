using System;
					
public class Program
{
	public VideoStates videoStates;
		
	public void Main()
	{
		videoStates = new VideoStates(); 
		videoStates.currentState = VideoStates.States.Rewind;
		videoStates.CheckState();
	}
}

public class VideoStates {
	
	public enum States {
		Play,
		Pause, 
		Rewind
	}
	
	public States currentState = States.Play;	
	
	
	public void CheckState () {
		switch (currentState) {
			case States.Play:
				Console.WriteLine("Play");
				break;
			case States.Pause:
				Console.WriteLine("Pause");
				break;
			case States.Rewind:
				Console.WriteLine("Rewind");
				break;
		}
	}
}