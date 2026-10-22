/** TreeApp.java
 *  Created for CTEC2901 Practical Week 9 by Nisansala Yatapanage.
 *  
 *  November 2017.
 */

package main;
import lib.BinaryTree;

public class TreeApp {

	public static void main(String[] args){
		BinaryTree<Integer> b1 = new BinaryTree<>(5, null, null); // a leaf node.
		BinaryTree<Integer> b2 = new BinaryTree<>(43, b1, null);
		BinaryTree<Integer> b3 = new BinaryTree<>(26, null, null);
		BinaryTree<Integer> b4 = new BinaryTree<>(79, b3, b2);
		BinaryTree<Integer> b5 = new BinaryTree<>(129, null, null);
		BinaryTree<Integer> b6 = new BinaryTree<>(47, null, b5);
		BinaryTree<Integer> b7 = new BinaryTree<>(220, b4, b6); // This is the root.
	
		printTree(b7);
		
	//  Uncomment these lines when you want to run addAll.
	//	int x = addAll(b7);
	//	System.out.println(x);
	
	//  Uncomment these lines when you want to run your multiplyAll.
	//  int y = multiplyAll(b7);
	//  System.out.println(y);
		
	//  Uncomment these lines when you want to run your doubleAll.
	//	doubleAll(b7);		
	//	printTree(b7);
		
	//  Uncomment these lines when you want to run your printPath.	
	//	boolean b = printPath(b7, 129);
	}
	
	/** This method prints a given tree.
	 * It calls printTree(BinaryTree<E> b, int depth).
	 * @param b - The tree to be printed.
	 * 
	 */
	public static void printTree(BinaryTree<Integer> b){
		printTree(b, 0);
	}
	
	/** This method prints a given tree recursively,
	 *  with each level indented using dashes.
	 * @param b - The tree to be printed.
	 * @param depth - The current depth.
	 */
	public static void printTree(BinaryTree<Integer> b, int depth){
		if (b != null){
			String output = "";
			for (int i = 0; i < depth; i++){
				output = output + "-";
			}
			output = output + b.getData();
			System.out.println(output);
			printTree(b.getLeft(), depth+1);
			printTree(b.getRight(), depth+1);
		}
	}
	
	/** This method adds all the numbers in a given tree.
	 * precondition: The tree must contain only integers.
	 * @param b - The tree.
	 * @return - The total sum of all the numbers.
	 */
	public static int addAll(BinaryTree<Integer> b){
		if (b != null){
			Integer num =b.getData();
			num = num + addAll(b.getLeft()) + addAll(b.getRight());
			return num;
		}
		return 0;
	}

}