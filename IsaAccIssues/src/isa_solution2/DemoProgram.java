package isa_solution2;

import java.util.*;
public class DemoProgram {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		ArrayList<Account> accounts = new ArrayList<>();
		
		accounts.add(new BankAccount());
		accounts.add(new InterestAccount());
		accounts.add(new IsaAccount());
		
		for (Account a : accounts) {
			System.out.println("Balance = " + a.getBalance());
			a.deposit(300);
			System.out.println("Balance = " + a.getBalance());
		}

	}

}
