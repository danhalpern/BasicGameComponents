public class Die{
	private static Random rnd = new Random();
	
	public static int RollDie(){
		return rnd.Next(1,7);
	}
	
	public static int[] RollDice(int numOfRolls){	//tallies numbers rolled and returns a 7-element array of results, ***element 0 remains unused***
		int [] rollHistory = new int[7];
		for (int i = 0; i < numOfRolls; i++){
			rollHistory[rnd.Next(1,7)]++;
		}
		return rollHistory;
	}
	
	public static int SumOfRolls(int numOfRolls){
		int sum = 0;
		for(int i = 0; i< numOfRolls; i++) sum+= rnd.Next(1,7);
		return sum;
	}
}