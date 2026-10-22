package main;
import lib.Node;
import lib.LinkedList;

public class ListApp {

	public static void main(String[] args){
		/* 
		 * the tail object/Node (last object in list) must be created first, directed to null as it is the last object/Node and has no object after it.
		 * Each new Node gets directed to the previous.
		 * The latest created Node will automatically become the head (first object in list)
		 */
		Node n4 = new Node("green", null);
		Node n3 = new Node("orange", n4);
		Node n2 = new Node("blue", n3);
		Node n1 = new Node("red", n2);

		LinkedList list = new LinkedList(n1);

		System.out.println(list);

		Node another = new Node("purple", null);
		list.insertAfter(another, n2);

		System.out.println(list);

		list.deleteAfter(n1);

		System.out.println(list);
		
		LinkedList originalList = list;
		
		//testing changeNextItem
		list = originalList;
		System.out.println("\nChangeNextItem...");
		System.out.println("Before: " + list);
		list.changeNextItem(n1, "yellow");
		System.out.println("After: " + list);
		
		//testing replaceAfter
		System.out.println("\nReplaceAfter...\nBefore: " + list);
		list = originalList;
		Node mytest = new Node("pink", another);
		list.replaceAfter(mytest, n1);
		System.out.println("After: " + list);
		
		//testing swap
		list = originalList;
		list.swap(n2);
		System.out.println(list);
	}
}
