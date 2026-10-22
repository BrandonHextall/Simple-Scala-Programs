package lib.bankaccounts;

public class StudentAccount extends BankAccount {
	
	// Fields
	private int overdraftLimit;
	
	// Constructors
	public StudentAccount() {
		overdraftLimit = 0;
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
	
	public void setOverdraft(int limit) {
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
