package lib.bankaccounts;

public class StudentAccount extends BankAccount {
	
	// Fields
	private int overdraftLimit;
	private int balance;
	
	// Constructors
	public StudentAccount() {
		balance = 0;
		overdraftLimit = 0;
	}
	
	public StudentAccount(int limit) {
		balance = 0;
		overdraftLimit = limit;
	}
	
	public StudentAccount(int balance, int limit) {
		super(balance);
		overdraftLimit = limit;
	}
	@Override
	public void withdraw(int amount) {
		if (super.getBalance() - amount >= -overdraftLimit) {
			super.withdraw(amount);
		} else System.out.println("Withdrawal will overflow overdraft limit");
	}
	
	public void setOverdraft(int balance, int limit) {
		overdraftLimit = limit;
	}
	
	public int getOverdraft() {
		return overdraftLimit;
	}
	
	@Override
	public String toString() {
		return super.toString() + "[overdraftLimit=" + overdraftLimit + "]";
	}
}
