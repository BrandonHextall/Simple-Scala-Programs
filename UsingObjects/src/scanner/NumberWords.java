package scanner;

// Question 11 (optional)
import java.util.Scanner;

public class NumberWords {
 public static void main(String[] args) {
	 Scanner sc = new Scanner(System.in);
	 System.out.println("Enter a sentence and press Enter");
	 String sentence = sc.nextLine();
	 int wordCount = sentence.split(" ").length;
	 System.out.println("Number of words: " + wordCount);
	 String[] vowels = sentence.split("");
	 int vowelCounter = 0;
	 float sentenceLength = sentence.length();
	 for (int i = 0; i < vowels.length; i ++) {
		 switch (vowels[i]) {
		 case "a":
		 case "e":
		 case "i":
		 case "o":
		 case "u":
			 vowelCounter ++ ;
			 
		 }
	 }
	 System.out.println("Number of vowels: " + vowelCounter);
	 float vowelPercentage = ((vowelCounter * 100)/ (sentenceLength * 100)) * 100;
	 System.out.println("Percentage of sentence are vowels: " + vowelPercentage + "%");
 }
}
