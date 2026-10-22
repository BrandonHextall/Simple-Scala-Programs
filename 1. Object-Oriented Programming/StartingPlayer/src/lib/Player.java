package lib;

/**
 * 
 * A player has a name, pair of dice, and a gamertag
 */
public class Player {

	// Fields
	private String gamertag;
	private Name name;
	private PairOfDice dice;
	
	// Constructors
	/* Create new instance of Player using blank values */
	public Player() {
		gamertag = "";
		name = new Name();
		dice = new PairOfDice();
	}
	
	/** Creates new instance of Player using given values for gamertag and name.
	 * 
	 * @param gamertag the Player's gamertag
	 * @param firstName the Player's first name
	 * @param familyName the Player's family name
	 * */
	public Player(String gamertag, String firstName, String familyName) {
		gamertag = gamertag;
		name = new Name(firstName, familyName);
		dice = new PairOfDice();
	}
	
	/** Creates new instance of Player using given values.
	 *  
	 *  @param gamertag the Player's gamertag
	 *  @param firstName the Player's first name
	 *  @param familyName the Player's family name
	 *  @param redSides the number of sides on the red die
	 *  @param blueSides the number of sides on the blue die
	 *  */
	public Player(String gamertag, String firstName, String familyName, int redSides, int blueSides) {
		gamertag = gamertag;
		name = new Name(firstName, familyName);
		dice = new PairOfDice(new Die(redSides), new Die(blueSides));
	}
	
	// Methods
	/** Returns the Player's name 
	 * @return the player's name */
	public Name getName() {
		return name;
	}
	
	/** sets the Player's name to the specified value.
	 * @param firstName Player's first name
	 * @param familyName Player's family name
	 */
	public void setName(String firstName, String familyName) {
		if (firstName.equals("") && familyName.equals("")) {
			name = new Name();
		} else name = new Name(firstName, familyName);
	}
	
	/** Returns Player's pair of dice.
	 * @return the pair of dice. */
	public PairOfDice getPairOfDice() {
		return dice;
	}
	
	/** Rolls the Player's dice */
	public void rollDice() {
		dice.roll();
	}
	
	/** Returns Player's dice score.
	 * @return sum of Player's dice roll. */
	public int getDiceScore() {
		return dice.getScore();
	}
	
	/** Sets Player's gamertag.
	 * @param gamertag Player's gamertag. */
	public void setGamertag(String gamertag) {
		gamertag = gamertag;
	}
	
	/** Returns Player's gamertag.
	 * @return the Player's gamertag. */
	public String getGamertag() {
		return gamertag;
	}
}
