package strings;

// Question 4
public class StringArrayDemo {
	public static void main(String[] args) {
		// a
		String[] fruit = {"apple", "orange", "pear", "banana", "kiwi", "grapefruit"};
		// b
		for (int i = 0; i < fruit.length; i ++) {
			System.out.println(fruit[i].toUpperCase());
		}
	}
}
