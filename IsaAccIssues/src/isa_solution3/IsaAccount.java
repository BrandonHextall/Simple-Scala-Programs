package isa_solution3;

public class IsaAccount implements Account {

	private InterestAccount acc;
	private int depositRemaining;
	
	public IsaAccount() {
		acc = new InterestAccount();
		depositRemaining = 0;
	}
	
	public IsaAccount(int balance, int interestRate, int minimumBalance, int depositRemaining) {
		acc = new InterestAccount(balance, interestRate, minimumBalance);
		this.depositRemaining = depositRemaining;
	}
	
	//GET and SET methods for depositRemaining
	
	public int getBalance() {
		return acc.getBalance();
	}
	
	public void deposit(int amount) {
		if (amount <= depositRemaining) {
			acc.deposit(amount);
			depositRemaining-=amount;
		}
	}
	
	
	
}
