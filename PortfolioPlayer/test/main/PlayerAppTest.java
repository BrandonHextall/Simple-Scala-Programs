package main;

import static org.junit.Assert.*;

import java.util.ArrayList;

import org.junit.Test;

import lib.Die;
import lib.Name;
import lib.PairOfDice;
import lib.Player;

public class PlayerAppTest {
	
	/* Please note - when we come to mark the solution to this unit test we will change the input
	 * data set for the players added to the list to ensure the solution works dynamically based
	 * upon any given data set and is not hardcoded in any way.
	 */
	@Test
	public void testExecute() {
		var players = new ArrayList<Player>();
		players.add(new Player(new PairOfDice(), new Name("Joe", "Bloggs"), "Jbloggs31"));
		players.add(new Player(new Die(), new Name("Fred", "Jones"), "Fjones20"));
		players.add(new Player(new PairOfDice(new Die(5), new Die(5)), new Name("Nila", "Singh"), "Nsing20"));
		players.add(new Player(new Die(), new Name("Anna", "Skye"), "Askye20"));
		
		String result = PlayerApp.execute(players, 20);
		
		String expectedResult = "FRED, jones\nANNA, skye\n";
		
		assertEquals("The string returned should match the expected result (run 1)", expectedResult, result);
		
		
		/* Test with a second set of input data */
		var players2 = new ArrayList<Player>();
		players2.add(new Player(new PairOfDice(), new Name("David", "Blunt"), "Dblunt20"));
		players2.add(new Player(new Die(5), new Name("Tim", "Jonas"), "Tother20"));
		players2.add(new Player(new Die(), new Name("Remi", "Patel"), "Rpatel20"));		
		players2.add(new Player(new PairOfDice(new Die(5), new Die(5)), new Name("Toby", "Castle"), "Tcastle20"));
		
		
		String result2 = PlayerApp.execute(players2, 20);
		
		String expectedResult2 = "DAVID, blunt\nREMI, patel\nTOBY, castle\n";
		
		assertEquals("The string returned should match the expected result (run 2)", expectedResult2, result2);
		
		
		/* Test with a third set of input data */
		var players3 = new ArrayList<Player>();
		players3.add(new Player(new PairOfDice(), new Name("David", "Blunt"), "Dblunt20"));
		players3.add(new Player(new Die(5), new Name("Tim", "Jonas"), "Tjonas35"));
		players3.add(new Player(new Die(), new Name("Remi", "Patel"), "Rpatel35"));		
		players3.add(new Player(new PairOfDice(new Die(5), new Die(5)), new Name("Toby", "Castle"), "Tcastle33"));
		
		
		String result3 = PlayerApp.execute(players3, 35);
		
		String expectedResult3 = "TIM, jonas\nREMI, patel\n";
		
		assertEquals("The string returned should match the expected result (run 3)", expectedResult3, result3);
	}
	
}
