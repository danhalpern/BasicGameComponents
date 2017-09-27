public class Card{
	public enum Suit : byte {Spades, Hearts, Diamonds, Clubs};
	static Random rnd = new Random();
	private int cardID = rnd.Next(52);
	
	public Card(int x){
		cardID = x % 52;
	}
	
	public override string ToString(){
		return this.CardName();
	}
	
	public override bool Equals(object obj){
		Card c = (Card) obj;
		return (this.CardName() == c.CardName());
	}
	
	public string FaceValue(){
		int nominalValue = this.cardID%13 +1;
		switch (nominalValue){
			case 1:
				return "Ace";
			case 11:
				return "Jack";
			case 12:
				return "Queen";
			case 13:
				return "King";
			default:
				return nominalValue.ToString();
		}
	}
	
	public Suit CardSuit(){
		return (Suit) (int)(this.cardID /13);	//integer part of cardID when divided by 13, cast as enum Suit
	}
	
	public string CardName(){
		return ($"{this.FaceValue()} of {this.CardSuit()}");
	}

}

public class Shoe{
	private const byte CARDS_PER_DECK = 52;
	Random rnd = new Random();
	
	private List<Card> cardsAvailable = new List<Card>();
	
	public Shoe(int numDecks = 1){
	for (int i = 0; i < numDecks; i++)
		for (int j = 0; j < CARDS_PER_DECK; j++)
			cardsAvailable.Add(new Card(j));
	}
	
	public void ListCards(){
		foreach (Card c in cardsAvailable) Console.WriteLine(c.CardName());
	}
	
	public Shoe ShuffledShoe(){		//returns a Shoe which contains the same Card objects but in randomised order
		Shoe sOld = this;
		Shoe sNew = new Shoe(0);
		
		//take cards in random order from sOld, add them to end of sNew
		int cardCount = cardsAvailable.Count;
		for (int i = 0; i < cardCount; i++){
			Card c = sOld.cardsAvailable[rnd.Next(sOld.cardsAvailable.Count)];
			sNew.cardsAvailable.Add(c);
			sOld.cardsAvailable.Remove(c);
		}
		
		return sNew;
	}
	
	public Card DrawOne(){		//returns null if shoe is empty, otherwise the first Card
		if (cardsAvailable.Count == 0) return null;
		Card c = this.cardsAvailable.First();
		this.cardsAvailable.Remove(c);
		return c;
	}
	
	public int Size(){
		return cardsAvailable.Count();
	}
	
}