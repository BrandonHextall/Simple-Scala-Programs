package lib;

public class LinkedList {
	private Node head;

	public LinkedList(Node h){
		head = h;
	}
	public Node getHead(){
		return head;
	}
	public void setHead(Node n){
		head = n;
	}
	public void insertAfter(Node newNode, Node prev){
		newNode.setNext(prev.next());
		prev.setNext(newNode);
	}

	public void deleteAfter(Node prev){
		prev.setNext(prev.next().next());
	}
	
	// Changes the node after given node
	public void changeNextItem(Node n, String str) {
		Node 	current = head,
				prev = current.next();
		while (current != n) {
			prev = current;
			current = current.next();
		}
		prev = current;
		current = current.next();
		current.setItem(str);
	}
	
	public void replaceAfter(Node newNode, Node prev) {
		if (prev == null) return;
		Node afterPrev = prev.next();
		/*if (afterPrev == null) {
			prev.setNext(newNode);
			newNode.setNext(null);
		}*/
		Node afterDeleted = afterPrev.next();
		prev.setNext(newNode);
		newNode.setNext(afterDeleted);
	}
	
	public void insertBefore(Node newNode, Node after) {
		Node 	current = head,
				prev = current.next();
		// Loop through the lust to find the place to insert.
		while (current != after) {
			prev = current;
			current = current.next();
		}
		// prev now points to the node before the place to insert.
		
		// Set the new node to point to after, and prev to point to the new node.
		newNode.setNext(after);
		prev.setNext(newNode);
	}
	
	// takes parameter node, swaps the 2 nodes AFTER the given node
	public void swap(Node n) {
		if (n == null) return;
		Node first = n.next();
		if (first == null) return;
		Node second = first.next();
		if (second == null) return;
		Node afterSecond = second.next();
		
	}

	public String toString(){
		String str = "";
		Node current = head;
		while(current != null){
			str = str + current.getItem();
			current = current.next();
			if (current != null){
				str = str + ", ";
			}
		}
		return str;
	}
}
