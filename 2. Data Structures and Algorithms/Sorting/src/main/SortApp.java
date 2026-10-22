package main;
import lib.Sorting;

public class SortApp {
	public static void main(String[] args){
		Sorting s = new Sorting();
		int[] numbers = {5,7,13,9,11,16,2,4,14};
		System.out.println("Original array: " + s.printArray(numbers));

		s.selectionSort(numbers);
		System.out.println("After selection sort: " + s.printArray(numbers));

		int[] numbers2 = {5,7,13,9,11,16,2,4,14};
		s.bubbleSort(numbers2);
		System.out.println("After bubble sort: " + s.printArray(numbers2));

		int[] numbers3 = {5,7,13,9,11,16,2,4,14};
		s.bubbleSort2(numbers3);
		System.out.println("After better bubble sort: " + s.printArray(numbers3));

		int[] numbers4 = {5,7,13,9,11,16,2,4,14};
		s.insertionSort(numbers4);
		System.out.println("After insertion sort: " + s.printArray(numbers4));

		int[] numbers5 = {5,7,13,9,11,16,2,4,14};
		s.quickSort(numbers5,0,numbers5.length-1);
		System.out.println("After quick sort: " + s.printArray(numbers5));
	}
	
	

}
