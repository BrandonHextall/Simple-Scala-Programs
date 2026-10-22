package main;

import java.util.*; 

public class StringListDemo {
	public static void main(String[] args) {
		List<String> list = new LinkedList<String>();
		list.add("hi");
		list.add("bye");
		list.add("ind2");
		list.add("ind3");
		list.add("ind4");
		list.add("ind5");
		
		System.out.println(list);
		list.set(0, "ind0");
		System.out.println(list);
		list.remove(3);
		System.out.println(list);
		
		list.forEach(e -> System.out.println(e.toUpperCase()));
		
		for (String s: list) {
			System.out.println(s.toLowerCase());
		}
	}
}
