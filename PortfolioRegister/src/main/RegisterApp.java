package main;

import lib.Name;
import lib.Register;

public class RegisterApp {

	/** Executes the Register.
	 * @param nme new name to be added to the register.
	 * @param reg given register to be executed
	 * @return returns the final String of emails
	 */
	public static String execute(Name nme, Register reg) {
		reg.removeName(1);
		StringBuilder finalString = new StringBuilder();
		reg.addName(nme);
		reg.forEach(name -> {if (name.getFirstName().contains("a") || name.getFirstName().contains("e")) finalString.append((name.getFirstName().substring(0, 1) + "." + name.getFamilyName().substring(0, 3) + "@email.com\n").toLowerCase());});
		return finalString.toString();
	}
}