public class Die{
	private static Random rnd = new Random();
	private int numSides;
	
	public Die(int numSides = 6){
		if (numSides < 4) numSides = 6;		//any value below 4 is reset to 6
		this.numSides = numSides;
	}
	
	public int RollDie(){
		return rnd.Next(1,this.numSides + 1);
	}
	
	public int[] RollDice(int numOfRolls){	//tallies numbers rolled and returns array of results, ***element 0 remains unused***
		int [] rollTally = new int[numSides + 1];
		for (int i = 0; i < numOfRolls; i++){
			rollTally[rnd.Next(1,numSides + 1)]++;
		}
		return rollTally;
	}
	
	public int SumOfRolls(int numOfRolls){
		int sum = 0;
		for(int i = 0; i< numOfRolls; i++) sum+= rnd.Next(1,numSides + 1);
		return sum;
	}
}
