/** BinaryTree.java
 *  Created for CTEC2901 Practical Week 9 by Nisansala Yatapanage.
 *  
 *  November 2017.
 */
package lib;

public class BinaryTree<E> {
	private E data;
	private BinaryTree<E> left;
	private BinaryTree<E> right;

	/** This constructor sets the data to be the given object
	 * and the left and right sub-trees to be the given trees.
	 * @param e - the data object,
	 * @param l - the left sub-tree,
	 * @param r - the right sub-tree.
	 */
	public BinaryTree(E e, BinaryTree<E> l, BinaryTree<E> r){
		data = e;
		left = l;
		right = r;
	}
	/**  This method returns the left sub-tree.
	 */
	public BinaryTree<E> getLeft(){
		return left;
	}
	
	/**  This method returns the right sub-tree.
	 */
	public BinaryTree<E> getRight(){
		return right;
	}
	
	/**  This method returns the data object.
	 */
	public E getData(){
		return data;
	}
	
	/**  This method sets the data object.
	 * @param e - the input data object.
	 */
	public void setData(E e){
		data = e;
	}
	/** This method sets the left sub-tree to be the given tree.
	 * @param l - The left sub-tree to be added.
	 */
	public void setLeft(BinaryTree<E> l){
		left = l;
	}
	
	/** This method sets the right sub-tree to be the given tree.
	 * @param r - The right sub-tree to be added.
	 */
	public void setRight(BinaryTree<E> r){
		right = r;
	}
	
}
