package lib;

public class ModuloCounter {
	// Fields
	private int count;
	private int max;
	
	// Constructors
	public ModuloCounter() {
		count = 0;
		max = 0;
	}
	
	public ModuloCounter(int count, int max) {
		this.count = count;
		this.max = max;
	}
	
	// Methods
	public void setCount(int count) {
		this.count = count;
	}
	
	public void setMax(int max) {
		this.max = max;
	}
	
	public int getCount() {
		return this.count;
	}
	
	public int getMax() {
		return max;
	}
	
	public void increment() {
		count = count + 1;
		if (count > max) count = 0;
	}
	
	public void incrementBy(int amount) {
		count = count + amount;
		if (count > max) count = 0;
	}
	
	public void decrement() {
		count = count - 1;
	}
	
	public void decrementBy(int amount) {
		count = count - amount;
	}
	
	public void reset() {
		count = 0;
	}
	
	public boolean isZero() {
		return count == 0;
	}
	
	@Override
	public String toString() {
		return "ModuloCounter:[count=" + count + ", max=" + max + "]";
	}
}
