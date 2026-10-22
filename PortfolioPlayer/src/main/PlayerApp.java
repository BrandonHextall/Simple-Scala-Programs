package main;

import java.util.ArrayList;

import lib.Player;

public class PlayerApp {

	/** Executes Player.
	 * @param gamers ArrayList containing Players
	 * @param value the number used to filter Player's gamertags
	 * @return returns final String of names
	 */
	public static String execute(ArrayList<Player> gamers, int value) {
		StringBuilder finalString = new StringBuilder();
		gamers.forEach(g -> {
			var name = g.getName();
			if (g.getGameTag().toLowerCase().contains((name.getFamilyName() + value).toLowerCase())) {
				var concat = name.getFirstName().toUpperCase() + ", " + name.getFamilyName().toLowerCase() + "\n";
				finalString.append(concat);
			}
		});
		return finalString.toString();
	}
	
}
