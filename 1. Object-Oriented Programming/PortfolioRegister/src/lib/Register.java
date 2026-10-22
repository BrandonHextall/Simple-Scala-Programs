package lib;

import java.util.*;

public class Register implements Iterable<Name> {
	
	//Fields
	private ArrayList<Name> list;
	private int capacity = 25;
	
	//Constructors
	/** Creates new instance of Register using default values.  Default size is 25*/
	public Register() {
		list = new ArrayList<Name>();
		capacity = 25;
	}
	
	/** Creates new instance of Register using given size. */
	public Register(int newCapacity) {
		list = new ArrayList<Name>();
		capacity = newCapacity;
	}
	
	//Methods
	/* Adds a new name to register.
	 * @param name the new name for the register. */
	public void addName(Name name) {
		if (list.size() < capacity) list.add(name);
	}
	
	/** Adds multiple names to register.
	 * @param names the new names for the register. */
	public void addNames(ArrayList<Name> names) {
		//print(list.size());
		if (list.size() + names.size() <= capacity) {
			list.addAll(names);
		}
	}
	
	/** Returns name in register based on index. 
	 * @param index position of name to return. */
	public Name getName(int index) {
		return list.get(index);
	}
	
	/** Returns the register. 
	 * @return register*/
	public ArrayList getRegister() {
		return list;
	}
	
	/** Returns size of register.
	 * @return size of register. */
	public int getRegisterSize() {
		return list.size();
	}
	
	/** Returns room capacity.
	 * @return capacity of register. */
	public int getCapacityOfRoom() {
		return capacity;
	}
	 
	/** Removes name from register based on index and returns the removed name.
	  * @param index position to remove.
	  * @return removed name. */
	public Name removeName(int index) {
		Name removedName = list.get(index);
		list.remove(index);
		return removedName;
	}
	
	/** Clears the register. */
	public void clearTheRegister() {
		list.clear();
	}
	
	/** Checks if register is empty. 
	 * Returns boolean value
	 * @return boolean of register. */
	public boolean isEmpty() {
		return list.size() == 0 ? true : false;
	}
	
	/** Counts the number of occurrences of a given first name.
	 * @param firstName the name to check occurrences. */
	public int countFirstNameOccurrences(String firstName) {
		int count = 0;
		for (Name n : list) {
			if (n.getFirstName().equalsIgnoreCase(firstName)) count ++;
		}
		return count;
	}
	
	/** Searches for names by taking initial of family name and returns boolean of if it exists.
	 * @param inital - the given initial to search by.
	 * @return boolean of whether initial exists in the register. */
	public boolean searchRegisterByFamilyNameInitial(char initial) {
		for (Name name : list) if (name.getFamilyName().charAt(0) == Character.toUpperCase(initial)) return true;
		return false;
	}
	
	/** Sorts the register. */
	public void sortRegister() {
		Collections.sort(list);
	}
	
	@Override
	public String toString() {
		return "Register:[" + capacity + ", " + list;
	}
	
	/** Makes the Register class iterable */
	@Override
	public Iterator<Name> iterator() {
	    return list.iterator();
	}
}
