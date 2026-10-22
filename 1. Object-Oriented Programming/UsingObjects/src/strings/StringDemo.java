package strings;

public class StringDemo {

	public static void main(String[] args) {
		
		//creates a String literal
		String myName = "Wayne Rooney";	
		//declares a variable of type char
		char c;
		
		//prints out the value of the String literal
		System.out.println(myName);
		
		//invokes the charAt method on the String literal object "myName" passing
		//the parameter value 3 and assigning the returned character to "c"
		c = myName.charAt(3);
		
		//concatenates the character to a String literal and prints it
		System.out.println("4th character is: " + c);

		//concatenates the int value returned by the length method
		//to another String literal and prints it.
		System.out.println("Length is: " + myName.length());		

		//invokes the endsWith method, passing the parameter value "ney"
		//and evaluates the boolean value returned
		if (myName.endsWith("ney") ) {
			System.out.println(myName + " ends with \"ney\" ");
		} else { 
			System.out.println(myName + " does not end with \"ney\" ");
		}

		//...TO COMPLETE...try more String methods listed in the API
		
		// My work
		// Question 2
		// toUpperCase
		System.out.println("\nMy Work\nQuestion 2");
		System.out.println("toUpperCase: " + myName.toUpperCase());
		// replace
		System.out.println("replace: " + myName.replace("e", "y"));
		// substring
		System.out.println("substring: " + myName.substring(0, 5));
		// indexOf
		System.out.println("indexOf: " + myName.indexOf("R"));
		
		//Question 3
		System.out.println("\nQuestion3");
		String name = "Brandon Hextall";
		String split[] = name.split(" ");
		String initials = new StringBuilder().append(split[0].charAt(0)).append(split[1].charAt(0)).toString();
		System.out.println(initials);
		System.out.println("Initials: " + split[0].charAt(0) + split[1].charAt(0));
		System.out.println("Email: " + initials.toLowerCase() + "@email.dmu.ac.uk");
		
	}

}
