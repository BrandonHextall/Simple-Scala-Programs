package isa_solution1;

/**
 * A StudentAccount is a BankAccount, with an overdraft limit. 
 * Withdrawals are allowed until this limit has been reached.
 */
public class StudentAccount extends BankAccount {
    
	//Fields
    private int overdraftLimit; // e.g. 10000 means that the balance is allowed to reach -10000 pence.

    
    //Constructors
    public StudentAccount() {
        super();
        overdraftLimit=0;
    }

    public StudentAccount(int balance, int overdraftLimit)
    {
    	super(balance);
    	this.overdraftLimit=overdraftLimit;
    }

    //Methods
    @Override
    public void withdraw(int amount) {
        if (getBalance()-amount >= -overdraftLimit)
        	super.withdraw(amount);
    }
    
    public int getOverdraftLimit() {
        return overdraftLimit;
    }

    public void setOverdraftLimit(int overdraftLimit) {
        this.overdraftLimit = overdraftLimit;
    }
    
    @Override
    public String toString() {
        return super.toString() + "[overdraftLimit=" + overdraftLimit + "]";
    }
}
