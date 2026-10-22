package textio;

import java.io.*;
import java.util.*;

public class NameProcessor {
	public static void main(String[] Args) throws FileNotFoundException {
		ArrayList<Name> list;
		var sc = new Scanner(new File("names.txt"));
		
		// Set the scanner's delimiters to andle brackets <> and new lines
		// Probably look this up
		sc.useDelimiter("[<>\r\n]+");
		String line = sc.next(); 			// Get first element
		while (!line.equals(("end"))) {	// While not terminator
			
			String[] name = line.split(" ");
			String firstName = name[0];
			String lastName = name[1];
			
			line = sc.next();
			
			PrintWriter pw = new PrintWriter("shorter_names.txt");
			System.out.println(firstName.length() + lastName.length() < 12);
			if (firstName.length() + lastName.length() < 12) {
				System.out.println(firstName + " " + lastName);
			}
		}
	}
}
