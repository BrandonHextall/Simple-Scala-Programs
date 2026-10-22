package isa_solution1;

public class IsaAccount extends InterestAccount {
	
	//Fields
	private int depositRemaining; //pence
	
	
	//Constructors
	public IsaAccount(int depositLimit) {
		super();
		depositLimit = 5000; //5000 pence i.e. £500
	}
	
	public IsaAccount(int balance, int interestRate, int minimumBalance, int depositRemaining) {
		super(balance, interestRate, minimumBalance);
		this.depositRemaining = depositRemaining;
	}
	
	
	//Methods
	@Override
    public void withdraw(int amount) {
		//do nothing? TAKE OUT?
    }
	
	@Override
    public void deposit(int amount) {
		if (amount <= depositRemaining) {
			super.deposit(amount);
			depositRemaining-=amount; //reduce the depositLimit
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
        return super.toString() + "[depositRemaining=" + depositRemaining + "]";
    }
	
	
}
