package lib;

public class LinkedList<E> {
	private Node<E> head;

	/** This constructor sets the head to be the given node.
	 * @param h - The node to become the head.
	 */
	public LinkedList(Node<E> h){
		head = h;
	}
	/**  This method returns the head node.
	 */
	public Node<E> getHead(){
		return head;
	}
	/** This method sets the head to be the given node.
	 * @param n - The node to become the new head.
	 */
	public void setHead(Node<E> n){
		head = n;
	}
	/** This method inserts the new node after the given prev node.
	 * @param newNode - The new node to be inserted.
	 * @param prev - The node before the place where it will be inserted.
	 */
	public void insertAfter(Node<E> newNode, Node<E> prev){
		newNode.setNext(prev.next());
		prev.setNext(newNode);
	}
	/** This method deletes the new node after the given prev node.
	 * @param prev - The node before the place where it will be inserted.
	 */
	public void deleteAfter(Node<E> prev){
		prev.setNext(prev.next().next());
	}

	/** This is a toString method used for printing the entire LinkedList.
	 *  It specifies that the items of each node will be printed in a single
	 *  line with commas in between.
	 */
	public String toString(){
		String str = "";
		Node<E> current = head;
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
