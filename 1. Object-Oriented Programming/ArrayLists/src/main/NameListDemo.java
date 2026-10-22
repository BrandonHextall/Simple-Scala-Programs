// Question 3

package main;

import java.util.*;
import lib.Name; 

public class NameListDemo {
	public static void main(String[] args) {
		List<Name> register = new ArrayList<>();
		Scanner scanner = new Scanner(System.in);
		for (int i = 0; register.size() < 4; i ++) {
			System.out.println("Enter first name: ");
			String firstName = scanner.nextLine();
			System.out.println("\nEnter family name: ");
			String familyName = scanner.nextLine();
			register.add(new Name(firstName, familyName));
		}
		register.forEach(fullName -> System.out.println(fullName.getFirstName() + " " + fullName.getFamilyName()));
		
		// Question 3 d
		boolean exists = register.stream().anyMatch(nm -> nm.getFamilyName().toLowerCase().equals("smith"));
		System.out.println(exists);
	}
}
