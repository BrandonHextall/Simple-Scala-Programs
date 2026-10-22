package isa_solution4;

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
		
	public int getBalance() {
		return acc.getBalance();
	}
	
	public void deposit(int amount) {
		if (amount <= depositRemaining) {
			acc.deposit(amount);
			depositRemaining-=amount;
		}
	}
	
	public int getDepositRemaining() {
		return depositRemaining;
	}

	public void setDepositRemaining(int depositRemaining) {
		this.depositRemaining = depositRemaining;
	}
	
	@Override
    public String toString() {
        return acc.toString() + "[depositRemaining=" + depositRemaining + "]";
    }
	
}
