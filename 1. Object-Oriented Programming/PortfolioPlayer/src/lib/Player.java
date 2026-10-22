package lib;
import java.util.*;

/**
 * 
 * A player has a name, pair of dice, and a gamertag
 */
public class Player implements Comparable<Player> {

	// Fields
	private String gamertag;
	private Name name;
	private Rollable die;
	
	// Constructors
	/* Create new instance of Player using blank values */
	public Player() {
		gamertag = "";
		name = new Name();
		die = new Die();
	}
	
	/** Creates new instance of Player using given values for gamertag and name.
	 * 
	 * @param gt the Player's gamertag
	 * @param n Player's full name
	 * */
	public Player(Name n, String gt) {
		gamertag = gt;
		name = n;
		die = new Die();
	}
	
	/** Creates new instance of Player using given values.
	 *  
	 *  @param gt the Player's gamertag
	 *  @param n the Player's name
	 *  @param r the new Die with specified number of sides
	 *  */
	public Player(Rollable r, Name n, String gt) {
		gamertag = gt;
		name = n;
		die = r;
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
	
	/** Sets Player's name using a single given value.
	 * @param n Player's new full name */
	public void setName(Name n) {
		name = n;
	}
	
	/** sets Player's full name to the given String.
	 * @param fullName Player's new full name */
	public void setFullPlayerName(String fullName) {
		String[] newName = fullName.split(" ");
		String firstName = newName[0];
		String lastName = newName[1];
		firstName = firstName.substring(0, 1).toUpperCase() + firstName.substring(1).toLowerCase();
		lastName = lastName.substring(0, 1).toUpperCase() + lastName.substring(1).toLowerCase();
		name = new Name(firstName, lastName);
	}
	
	/** generates a new gamertag for the Player.
	 * @param num the number given to be added to the gamertag.
	 */
	public void generateGameTag(int num) {
		if (num > 0  && num < 101) {
			String reverseLastName = new StringBuilder(name.getFamilyName()).reverse().toString();
			String reverseFirstName = new StringBuilder(name.getFirstName()).reverse().toString();
			gamertag = (reverseLastName + reverseFirstName + num).toLowerCase();
		} else {}
	}
	
	/** Returns Player's rollable.
	 * @return the rollable. */
	public Rollable getRollable() {
		return die;
	}
	
	/** Rolls the Player's dice */
	public void rollDice() {
		die.roll();
	}
	
	/** Returns Player's die score.
	 * @return Player's roll score. */
	public int getDiceScore() {
		return die.getScore();
	}

	/** Sets Player's gamertag.
	 * @param gamertag Player's gamertag. */
	public void setGameTag(String gt) {
		gamertag = gt;
	}
	
	/** Returns Player's gamertag.
	 * @return the Player's gamertag. */
	public String getGameTag() {
		return gamertag;
	}
	
	@Override
	public int compareTo(Player other) {
	    int nameCompare = this.name.compareTo(other.name);
	    if (nameCompare != 0) {
	        return nameCompare;
	    }
	    // if names are equal, compare gamertags (ascending)
	    return this.gamertag.compareToIgnoreCase(other.gamertag);
	}
	
	@Override
	public String toString() {
		return "Player:[name:" + name + ", roll" + die + ", gamertag: " + gamertag + "]";
	}
}
