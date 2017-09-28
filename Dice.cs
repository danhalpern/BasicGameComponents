public class Dice{
	private Die [] dice;
	private int numDice;
	
	public Dice(int numDice = 2) : 
		this (numDice, 6)
	{
	}
	
	public Dice(int numDice, int sidesPerDie){
		this.numDice = numDice;
		dice = new Die[this.numDice];
		for (int i = 0; i < dice.Length; i++){
			dice[i] = new Die(sidesPerDie);
		}
	}
	
	public int[] CurrentValues(){
		int [] values = new int[dice.Count()];
		for (int i = 0; i < dice.Count(); i++){
			values[i] = dice[i].CurrentValue();
		}
		return values;		
	}
	
	public override string ToString(){
		string str = "Current dice values are: ";
		foreach (Die d in dice) str = str + d.ToString() + ", ";
		str = str.Substring(0, str.Length - 2);
		return str;
	}
	
	public int[] Roll(){
		foreach(Die d in dice) d.RollDie();
		return CurrentValues();
	}	
}
