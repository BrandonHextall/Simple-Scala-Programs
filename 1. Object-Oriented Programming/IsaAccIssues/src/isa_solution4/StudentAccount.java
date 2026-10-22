package isa_solution4;

/**
 * A StudentAccount is a BankAccount, with an overdraft limit. 
 * Withdrawals are allowed until this limit has been reached.
 */
public class StudentAccount implements Withdrawable {
    
	//Fields
	private BankAccount acc;
    private int overdraftLimit; // e.g. 10000 means that the balance is allowed to reach -10000 pence.

    
    //Constructors
    public StudentAccount() {
        acc = new BankAccount();
        overdraftLimit=0;
    }

    public StudentAccount(int balance, int overdraftLimit)
    {
    	acc = new BankAccount(balance);
    	this.overdraftLimit=overdraftLimit;
    }

    //Methods
    public void withdraw(int amount) {
        if (acc.getBalance()-amount >= -overdraftLimit)
        	acc.withdraw(amount);
    }
    
    public int getOverdraftLimit() {
        return overdraftLimit;
    }

    public void setOverdraftLimit(int overdraftLimit) {
        this.overdraftLimit = overdraftLimit;
    }
    
    public int getBalance() {
    	return acc.getBalance();
    }
    
    public void deposit(int amount) {
    	acc.deposit(amount);
    }
    
    @Override
    public String toString() {
        return acc.toString() + "[overdraftLimit=" + overdraftLimit + "]";
    }
}
