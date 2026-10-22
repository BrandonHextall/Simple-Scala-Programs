package main;

import lib.ModuloCounter;

public class ModuloCounterDemo {
	public static void main(String[] args) {
		System.out.println("Demonstrating some core functionality of the ModuloCounter... \n========");
		System.out.println("Using default constructor initialisation and get method...");
		ModuloCounter c = new ModuloCounter();
		System.out.println("Expected 0: Actual: " + c.getCount());
		
		System.out.println("Using set max value...");
		c.setMax(100);
		System.out.println("Expected: 100, Actual: " + c.getMax());
		
		System.out.println("Using increment method...");
		c.increment();
		c.increment();
		System.out.println("Expected 2: Actual: " + c.getCount());
		
		System.out.println("Using set count method...");
		c.setCount(10);
		System.out.println("Expected: 10, Actual: " + c.getCount());
		
		System.out.println("\nUsing custom constructor initialisation...");
		ModuloCounter c1 = new ModuloCounter(5, 100);
		System.out.println("Expected: 5100, Actual: " + c1.getCount() + "" + c1.getMax());
		
		System.out.println("Using toString method...");
		System.out.println("Expected: ModuloCounter:[count=" + c1.getCount() + ", max=" + c1.getMax() + "], Actual: " + c1.toString());
		
		System.out.println("\nUsing wrap method...");
		c1.setCount(90);
		for (int i = 0; i <= 20; i ++) {
			c1.increment();
		}
		System.out.println("Expected: 10, Actual: " + c1.getCount());
	}
}
