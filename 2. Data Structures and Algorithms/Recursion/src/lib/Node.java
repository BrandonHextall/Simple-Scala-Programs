package lib;

public class Node<E> {
	private E item;
	private Node<E> nextItem;

	/** This constructor sets the item to be the given value
	 *  and the next node to be the given node.
	 * @param e
	 * @param n
	 */
	public Node(E e, Node<E> n){
		item = e;
		nextItem = n;
	}
	/**  This method returns the item.
	 */
	public E getItem(){
		return item;
	}
	/** This method sets the item to be the given value.
	 * @param e - The String to be set.
	 */
	public void setItem(E e){
		item = e;
	}
	/** This method returns the next node.
	 */
	public Node<E> next(){
		return nextItem;
	}
	/** This method sets the next node to be the given node.
	 * @param n
	 */
	public void setNext(Node<E> n){
		nextItem = n;
	}
}
