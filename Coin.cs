public class Coin{
	public enum Face : byte {Heads, Tails};
	private static Random rnd = new Random();
	
	public static Face TossCoin(){	//returns Heads or Tails at random
		return (Face) rnd.Next(2);
	}
	
	public static int TossCoin(int numberOfTosses){	//returns number of Tails that result from the given number of random coin tosses
		int tailsCount = 0;
		for(int i = 0; i<numberOfTosses; i++) tailsCount += rnd.Next(2);
		return tailsCount;
	}
	
}